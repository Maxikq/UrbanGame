﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace WebService.DTOs
{
    public class Alert : DTOBase, IAlert
    {
        public Alert()
        {
        }

        #region Id

        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    NotifyPropertyChanging("Id");
                    _id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }
        #endregion

        #region IAlert.Game

        private IGame _game;

        public IGame Game
        {
            get
            {
                return _game;
            }
            set
            {
                if (_game != value)
                {
                    NotifyPropertyChanging("Game");
                    _game = value;
                    NotifyPropertyChanged("Game");
                }
            }
        }
        #endregion

        #region Topic

        private string _topic;

        public string Topic
        {
            get
            {
                return _topic;
            }
            set
            {
                if (_topic != value)
                {
                    NotifyPropertyChanging("Topic");
                    _topic = value;
                    NotifyPropertyChanged("Topic");
                }
            }
        }

        #endregion

        #region Description

        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (_description != value)
                {
                    NotifyPropertyChanging("Description");
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        #endregion

        #region AlertAppear

        private DateTime _alertAppear;

        public DateTime AlertAppear
        {
            get
            {
                return _alertAppear;
            }
            set
            {
                if (_alertAppear != value)
                {
                    NotifyPropertyChanging("AlertAppear");
                    _alertAppear = value;
                    NotifyPropertyChanged("AlertAppear");
                }
            }
        }
        #endregion
    }
}
