﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rockx.Data
{
    public interface IDbHandler
    {
        Task<List<Person>> GetPeopleFromGroup(int groupId);
        Task<List<DateTime>> GetDates();
        Task<List<Person>> GetPeopleForDate(DateTime date);
        Task<int> GetGuestsForDate(DateTime date);
        Task AddAttendance(List<Attendance> attendance, int guestCount);
    }
}