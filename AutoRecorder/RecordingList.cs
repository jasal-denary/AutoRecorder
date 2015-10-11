﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRecorder
{
    class RecordingList
    {
        private List<Recording> records;

        public RecordingList()
        {
            records = new List<Recording>();
        }

        public void AddRecording(Recording record)
        {
            records.Add(record);
        }

        public List<Recording> Records
        {
            get
            {
                return records;
            }
        }
    }
}