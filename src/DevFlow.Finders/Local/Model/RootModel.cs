﻿using DevFlow.Data;
using DevFlow.Finders.Local.Api;
using DevFlow.Windowbase.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace DevFlow.Finders.Local.Model
{
    public class RootModel : ObservableData
    {
        private bool _isExpanded;
        private bool _isSelected;
        private bool _isDenied;

        public string FullPath { get; set; }

        public int Depth { get; }

        public string Name { get; set; }

        public string FileName
        {
			get { return Path.GetFileName(FullPath) == "" ? FullPath : Path.GetFileName(FullPath); }
        }

        public long Length { get; set; }

        public bool IsExpanded
        {
            get => _isExpanded;
            set { _isExpanded = value; OnPropertyChanged(); }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set { _isSelected = value; OnPropertyChanged(); }
        }

        public bool IsDenied
        {
            get => _isDenied;
            set { _isDenied = value; OnPropertyChanged(); }
        }

        public GeoIcon IconType { get; }

        public ObservableCollection<RootModel> Children { get; private set; }

        public RootModel(int depth, string name, GeoIcon icon, string fullPath, bool isExpanded, bool isSelected)
        {
            FullPath = fullPath;
            Depth = depth;
            Name = name;
            IconType = icon;
            IsExpanded = isExpanded;
            IsSelected = isSelected;
            Children = new ObservableCollection<RootModel>();
        }

        public RootModel(string target, GeoIcon icon) : this(0, Path.GetFileName(target), RootIcon.Folder, target, false, false)
        {

        }

        internal void AddRange(IList<RootModel> rootModels)
        {
            Children.Clear();

            foreach (var item in rootModels)
            {
                Children.Add(item);
            }
        }
    }
}
