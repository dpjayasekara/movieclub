﻿using MovieClub.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieClub.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        
        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }


        [HttpPost]
        [HandleError]
        [ValidateAntiForgeryToken]
        public ActionResult AddMovie(Models.MovieDetails movie, HttpPostedFileBase uploadFile)
        {

            if (ModelState.IsValid)
            {
                

                //upload trailer start
                if (uploadFile != null)
                {
                    if (uploadFile.ContentLength > 0)
                    {
                        if (Path.GetExtension(uploadFile.FileName) == ".mp4")
                        {
                            string filePath = Path.Combine(HttpContext.Server.MapPath("/Content/multimedia"), Path.GetFileName(movie.ImdbId + ".mp4"));
                            uploadFile.SaveAs(filePath);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Could not upload trailer! Video file extension should be \".mp4\" ");
                            return View(movie);
                        }
                    }
                }

                //if video was uploaded successfully, then save the movie poster
                SavePoster(movie.PosterURL, movie.ImdbId);
                //save movie to db
                MovieDB.MovieClubDBE db = new MovieDB.MovieClubDBE();
                if (AddMovieToDB(db, movie))
                {
                    ViewBag.SuccessMessage = "Movie \"" + movie.Name + "\" added successfully!";
                    ModelState.Clear();
                }
                else
                {
                    ModelState.AddModelError("", "Could not add movie to the database! Check your connection.");
                }


                return View();

            }
            ModelState.AddModelError("", "Error occured adding movie! Check whether required fields are filled.");
            return View(movie);
        }


        public bool AddMovieToDB(MovieDB.MovieClubDBE db, MovieDetails movie)
        {
            try
            {
                MovieDB.DBMovie dbmovie = new MovieDB.DBMovie();
                MovieDB.DBCategory dbcat = new MovieDB.DBCategory();
                dbmovie.Actors = movie.Actors;
                dbmovie.Awards = movie.Awards;
                dbmovie.Country = movie.Country;
                dbmovie.Director = movie.Director;
                dbmovie.Genre = movie.Genre;
                dbmovie.ImdbId = movie.ImdbId;
                dbmovie.ImdbRatings = movie.ImdbRatings;
                dbmovie.ImdbVotes = movie.ImdbVotes;
                dbmovie.Language = movie.Language;
                dbmovie.MovieClubRatings = movie.MovieClubRatings;
                dbmovie.MovieClubRentCount = movie.MovieClubRentCount;
                dbmovie.Name = movie.Name;
                dbmovie.PlotFull = movie.PlotFull;
                dbmovie.PlotShort = movie.PlotShort;
                dbmovie.PosterURL = movie.PosterURL;
                dbmovie.ReleaseDate = movie.ReleaseDate;
                dbmovie.Runtime = movie.Runtime;
                dbmovie.Writer = movie.Writer;
                dbmovie.Year = movie.Year;
                dbmovie.AddedDate = DateTime.Today;
                db.DBMovies.Add(dbmovie);

                string[] categories = (movie.Genre).Split(',');
                List<MovieDB.DBCategory> currentlist = db.DBCategories.ToList<MovieDB.DBCategory>();
                foreach (string cat in categories)
                {
                    cat.Replace(" ", "");
                    if ((currentlist.FindAll(c => c.CategoryName == cat)).Count == 0)
                    {
                        dbcat.CategoryName = cat;
                        db.DBCategories.Add(dbcat);
                        db.SaveChanges();
                    }
                }

                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
            return true;
            
        }


        public void SavePoster(string Url, string ImdbId)
        {
            string LocalPath = HttpContext.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["PosterDownloadPath"]) + "/" + ImdbId + Path.GetExtension(Url);
            WebClient client = new WebClient();
            client.DownloadFile(Url,LocalPath);
            return;
        }
    }

    

}
