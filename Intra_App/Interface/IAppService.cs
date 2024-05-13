﻿using Intra_App_Prj.BLL.DTO;
using Intra_App_Prj.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Intra_App_Prj.Interface
{
    public interface IAppService
    {
        public List<DashBoardModel> DashboardView(string nos, string id);
        public string AddNews(NewsDTO nDTO, string id);
        public List<News> GetAllNews();
        public List<News>? GetEidNews(string eid);

        public List<News>? GetNewsDetails(string news_id);

        public string AddEvents(EventDTO eDTO, string id, string role);

        public List<Event>? GetEidEvents(string eid);

        public List<User> GetEidProfile(string eid);

        public string UpdateAtendeStatus(string status, string id, string event_id);

        public string UpdateEventStatus(string status, string event_id);

        public List<Event> Approvals(string status);

        public List<User> GetParticipants(string event_id, string status);

        public List<User> GetAllUsers();
        public List<User> GetBirthdayMonth(string month);
        public Task<string> Remove_user(string eid);
        public Task<string> Edit_employee(EditUserModelAdmin userNewDets);
        public Task<string> Edit_password(PwdChangeModel pwds, string id);
        public  Task<string> Edit_profile(EditUserModelUser NewDets,string id);
        public string React_to_news(string news_id, Boolean reaction,string id);
        public ReactionList NewsReactionList(string news_id);
    }
}
