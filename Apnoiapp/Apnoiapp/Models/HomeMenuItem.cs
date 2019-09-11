﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Apnoiapp.Models
{
    public enum MenuItemType
    {
        Home,
        ClassSchedule,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
