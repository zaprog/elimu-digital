﻿using Common;
using DAL.Contexts;
using DAL.Models;
using DAL.Models.Fees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class RepositoryFactory : IRepositoryFactory
    {
        #region Private Variables
        private readonly LePadContext _context;
        private readonly IRepository<Answer> _answers;
        private readonly IRepository<Comment> _comments;
        private readonly IRepository<Content> _contents;
        private readonly IRepository<Course> _courses;
        private readonly IRepository<Exam> _exams;
        private readonly IRepository<Like> _likes;
        private readonly IRepository<Location> _locations;
        private readonly IRepository<Profile> _profiles;
        private readonly IRepository<Question> _questions;
        private readonly IRepository<School> _schools;
        private readonly IRepository<Score> _scores;
        private readonly IRepository<Unit> _units;
        private readonly IRepository<Student> _students;
        private readonly IRepository<StudentUnit> _studentUnits;
        private readonly IRepository<Lecturer> _lecturers;
        private readonly IRepository<Admin> _admins;
        private readonly IRepository<Class> _classes;
        private readonly IRepository<Notification> _notifications;
        private readonly IRepository<DiscussionBoard> _boards;
        private readonly IRepository<Post> _posts;
        private readonly IRepository<CourseworkProgress> _progress;
        private readonly IRepository<StudentCourse> _studentCourses;
        private readonly IRepository<ExamSession> _examSessions;
        private readonly IRepository<FeeStructure> _feeStructures;
        private readonly IRepository<FeePayment> _feePayments;
        private readonly IRepository<BaseFeeStructure> _baseFeeStructures;
        #endregion

        public RepositoryFactory(LePadContext context)
        {
            _context = context;

            _answers = new Repository<Answer>(_context);
            _comments = new Repository<Comment>(_context);
            _contents = new Repository<Content>(_context);
            _courses = new Repository<Course>(_context);
            _exams = new Repository<Exam>(_context);
            _likes = new Repository<Like>(_context);
            _locations = new Repository<Location>(_context);
            _profiles = new Repository<Profile>(_context);
            _questions = new Repository<Question>(_context);
            _schools = new Repository<School>(_context);
            _scores = new Repository<Score>(_context);
            _units = new Repository<Unit>(_context);
            _students = new Repository<Student>(_context);
            _studentUnits = new Repository<StudentUnit>(_context);
            _lecturers = new Repository<Lecturer>(_context);
            _admins = new Repository<Admin>(_context);
            _classes = new Repository<Class>(_context);
            _notifications = new Repository<Notification>(_context);
            _boards = new Repository<DiscussionBoard>(_context);
            _posts = new Repository<Post>(_context);
            _progress = new Repository<CourseworkProgress>(_context);
            _studentCourses = new Repository<StudentCourse>(_context);
            _examSessions = new Repository<ExamSession>(_context);
            _feeStructures = new Repository<FeeStructure>(_context);
            _feePayments = new Repository<FeePayment>(_context);
            _baseFeeStructures = new Repository<BaseFeeStructure>(_context);
        }

        public IRepository<Answer> Answers => _answers;

        public IRepository<Comment> Comments => _comments;

        public IRepository<Content> Contents => _contents;

        public IRepository<Course> Courses => _courses;

        public IRepository<Exam> Exams => _exams;

        public IRepository<Like> Likes => _likes;

        public IRepository<Location> Locations => _locations;

        public IRepository<Profile> Profiles => _profiles;

        public IRepository<Question> Questions => _questions;

        public IRepository<School> Schools => _schools;

        public IRepository<Score> Scores => _scores;

        public IRepository<Unit> Units => _units;

        public IRepository<Student> Students => _students;

        public IRepository<Lecturer> Lecturers => _lecturers;

        public IRepository<Admin> Administrators => _admins;

        public IRepository<Class> Classes => _classes;

        public IRepository<Notification> Notifications => _notifications;

        public IRepository<StudentUnit> StudentUnits => _studentUnits;

        public IRepository<DiscussionBoard> DiscussionBoards => _boards;
        public IRepository<Post> Posts => _posts;

        public IRepository<CourseworkProgress> CourseworkProgress => _progress;

        public IRepository<StudentCourse> StudentCourses => _studentCourses;

        public IRepository<ExamSession> ExamSessions => _examSessions;

        public IRepository<FeeStructure> FeeStructures => _feeStructures;

        public IRepository<FeePayment> FeePayments => _feePayments;

        public IRepository<BaseFeeStructure> BaseFeeStructures => _baseFeeStructures;

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
