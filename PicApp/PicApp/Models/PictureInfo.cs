using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PicApp.Models
{
    public class PictureInfo : INotifyPropertyChanged
    {
        private string _nameFile;
        private string _pathToPicture;
        private DateTime _createDate;

        public PictureInfo(string nameFile, string pathToPicture, DateTime createDate)
        {
            _nameFile = nameFile;
            _pathToPicture = pathToPicture;
            _createDate = createDate;
        }

        public string NameFile
        {
            get { return _nameFile; }
            set
            {
                if (_nameFile != value)
                {
                    _nameFile = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PathToPicture
        {
            get { return _pathToPicture; }
            set
            {
                if (_pathToPicture != value)
                {
                    _pathToPicture = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
            set
            {
                if (_createDate != value)
                {
                    _createDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}