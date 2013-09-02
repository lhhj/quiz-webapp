﻿using System;
using System.Linq;
using System.Web.Http;
using PlayCode2013Quiz.Models;

namespace PlayCode2013Quiz.Controllers
{
    public class QuestionsController : ApiController
    {
        private PlayCode2013QuizDB db = new PlayCode2013QuizDB();

        // GET api/Questions
        [Queryable]
        public IQueryable<Question> GetQuestions()
        {
            return db.Questions;
        }

        [HttpGet]
        public int Count()
        {
            return db.Questions.Count();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}