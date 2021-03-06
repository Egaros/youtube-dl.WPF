﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using youtube_dl.WPF.Core.Services;

namespace youtube_dl.WPF.Presentation.ViewModels.DesignTime
{
    internal class DesignTimeShellViewModel : ShellViewModel
    {
        public DesignTimeShellViewModel() : base(
            DummyYouTubeDLService.Instance,
            new DesignTimeAddDownloadQueueEntryViewModel(),
            new DesignTimeDownloadQueueViewModel(),
            new DesignTimeDownloadViewModel(),
            new DesignTimeUtilsViewModel())
        {
        }
    }
}