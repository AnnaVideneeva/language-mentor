﻿using System.Collections.Generic;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces
{
    public interface ITestsService
    {
        IEnumerable<Task> GetTrialTest();
    }
}