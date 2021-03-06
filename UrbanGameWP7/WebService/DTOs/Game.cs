﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.Linq;
using Newtonsoft.Json;

namespace WebService.DTOs
{
    public class Game : DTOBase, IGame
    {
        const string imagesUrl = "http://urbangame.patronage.blstream.com/";

        public Game()
        {
            _tasks = new EntityEnumerable<ITask, GameTask>(new EntitySet<GameTask>(OnTaskAdded, OnTaskRemoved));
            _alerts = new EntityEnumerable<IAlert, Alert>(new EntitySet<Alert>(OnAlertAdded, OnAlertRemoved));
            _highScores = new EntityEnumerable<IHighScore, HighScore>(new EntitySet<HighScore>(OnHighScoreAdded, OnHighScoreRemoved));
        }
        #region Id

        private int _id;

        [JsonProperty(PropertyName = "gid")]
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

        #region Name

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    NotifyPropertyChanging("Name");
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        #endregion

        #region OperatorName

        private string _operatorName;

        public string OperatorName
        {
            get
            {
                return _operatorName;
            }
            set
            {
                if (_operatorName != value)
                {
                    NotifyPropertyChanging("OperatorName");
                    _operatorName = value;
                    NotifyPropertyChanged("OperatorName");
                }
            }
        }
        #endregion

        #region Localization

        private string _localization;

        [JsonProperty(PropertyName="location")]
        public string Localization
        {
            get
            {
                return _localization;
            }
            set
            {
                if (_localization != value)
                {
                    NotifyPropertyChanging("Localization");
                    _localization = value;
                    NotifyPropertyChanged("Localization");
                }
            }
        }
        #endregion

        #region GameLogo

        private string _gameLogo;

        [JsonProperty(PropertyName = "image")]
        public string GameLogo
        {
            get
            {
                return _gameLogo;
            }
            set
            {
                if (_gameLogo != value)
                {
                    NotifyPropertyChanging("GameLogo");
                    _gameLogo = value;
                    NotifyPropertyChanged("GameLogo");
                    NotifyPropertyChanged("GameLogoFullUrl");
                }
            }
        }
        #endregion

        #region GameLogoFullUrl
        public string GameLogoFullUrl
        {
            get
            {
                #if MOCK
                    return GameLogo;
                #else
                    return imagesUrl + GameLogo;
                #endif
            }
        }
        #endregion

        #region GameStart

        private DateTime _gameStart;

        [JsonProperty(PropertyName="startTime")]
        public DateTime GameStart
        {
            get
            {
                return _gameStart;
            }
            set
            {
                if (_gameStart != value)
                {
                    NotifyPropertyChanging("GameStart");
                    _gameStart = value;
                    NotifyPropertyChanged("GameStart");
                }
            }
        }
        #endregion

        #region GameEnd

        private DateTime _gameEnd;

        [JsonProperty(PropertyName = "endTime")]
        public DateTime GameEnd
        {
            get
            {
                return _gameEnd;
            }
            set
            {
                if (_gameEnd != value)
                {
                    NotifyPropertyChanging("GameEnd");
                    _gameEnd = value;
                    NotifyPropertyChanged("GameEnd");
                }
            }
        }
        #endregion

        #region GameType

        private GameType _gameType;

        [JsonProperty(PropertyName = "winning")]
        public GameType GameType
        {
            get
            {
                return _gameType;
            }
            set
            {
                if (_gameType != value)
                {
                    NotifyPropertyChanging("GameType");
                    _gameType = value;
                    NotifyPropertyChanged("GameType");
                }
            }
        }
        #endregion

        #region Points

        private int _points;

        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (_points != value)
                {
                    NotifyPropertyChanging("Points");
                    _points = value;
                    NotifyPropertyChanged("Points");
                }
            }
        }
        #endregion

        #region MaxPoints

        private int _maxPoints;

        public int MaxPoints
        {
            get
            {
                return _maxPoints;
            }
            set
            {
                if (_maxPoints != value)
                {
                    NotifyPropertyChanging("MaxPoints");
                    _maxPoints = value;
                    NotifyPropertyChanged("MaxPoints");
                }
            }
        }
        #endregion

        #region NumberOfPlayers

        private int _numberOfPlayers;

        public int NumberOfPlayers
        {
            get
            {
                return _numberOfPlayers;
            }
            set
            {
                if (_numberOfPlayers != value)
                {
                    NotifyPropertyChanging("NumberOfPlayers");
                    _numberOfPlayers = value;
                    NotifyPropertyChanged("NumberOfPlayers");
                }
            }
        }
        #endregion

        #region NumberOfSlots

        private int _numberOfSlots;

        [JsonProperty(PropertyName="maxPlayers")]
        public int NumberOfSlots
        {
            get
            {
                return _numberOfSlots;
            }
            set
            {
                if (_numberOfSlots != value)
                {
                    NotifyPropertyChanging("NumberOfSlots");
                    _numberOfSlots = value;
                    NotifyPropertyChanged("NumberOfSlots");
                }
            }
        }
        #endregion

        #region GameLatitude

        private double _gameLatitude;

        public double GameLatitude
        {
            get
            {
                return _gameLatitude;
            }
            set
            {
                if (_gameLatitude != value)
                {
                    NotifyPropertyChanging("GameLatitude");
                    _gameLatitude = value;
                    NotifyPropertyChanged("GameLatitude");
                }
            }
        }
        #endregion

        #region GameLongitude

        private double _gameLongitude;

        public double GameLongitude
        {
            get
            {
                return _gameLongitude;
            }
            set
            {
                if (_gameLongitude != value)
                {
                    NotifyPropertyChanging("GameLongitude");
                    _gameLongitude = value;
                    NotifyPropertyChanged("GameLongitude");
                }
            }
        }
        #endregion

        #region GameState

        private GameState _gameState;

        public GameState GameState
        {
            get
            {
                return _gameState;
            }
            set
            {
                if (_gameState != value)
                {
                    NotifyPropertyChanging("GameState");
                    _gameState = value;
                    NotifyPropertyChanged("GameState");
                }
            }
        }
        #endregion

        #region GameOverDisplayed
        private bool _gameOverDisplayed;

        public bool GameOverDisplayed
        {
            get
            {
                return _gameOverDisplayed;
            }
            set
            {
                if (_gameOverDisplayed != value)
                {
                    NotifyPropertyChanging("GameOverDisplayed");
                    _gameOverDisplayed = value;
                    NotifyPropertyChanged("GameOverDisplayed");
                }
            }
        }
        #endregion

        #region Rank

        private int? _rank;

        public int? Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if (_rank != value)
                {
                    NotifyPropertyChanging("Rank");
                    _rank = value;
                    NotifyPropertyChanged("Rank");
                }
            }
        }
        #endregion

        #region Difficulty

        private GameDifficulty _difficulty;

        public GameDifficulty Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                if (_difficulty != value)
                {
                    NotifyPropertyChanging("GameDifficulty");
                    _difficulty = value;
                    NotifyPropertyChanged("GameDifficulty");
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

        #region Prizes

        private string _prizes;

        [JsonProperty(PropertyName = "awards")]
        public string Prizes
        {
            get
            {
                return _prizes;
            }
            set
            {
                if (_prizes != value)
                {
                    NotifyPropertyChanging("Prizes");
                    _prizes = value;
                    NotifyPropertyChanged("Prizes");
                }
            }
        }
        #endregion

        #region IGame.Tasks

        private IEntityEnumerable<ITask> _tasks;

        public IEntityEnumerable<ITask> Tasks
        {
            get
            {
                return _tasks;
            }
        }

        private void OnTaskAdded(GameTask task)
        {
            task.Game = this;
        }

        private void OnTaskRemoved(GameTask task)
        {
            task.Game = null;
        }
        #endregion

        #region IGame.Alerts

        private IEntityEnumerable<IAlert> _alerts;

        public IEntityEnumerable<IAlert> Alerts
        {
            get
            {
                return _alerts;
            }
        }

        private void OnAlertAdded(Alert alert)
        {
            alert.Game = this;
        }

        private void OnAlertRemoved(Alert alert)
        {
            alert.Game = null;
        }
        #endregion

        #region IGame.HighScores

        private IEntityEnumerable<IHighScore> _highScores;

        public IEntityEnumerable<IHighScore> HighScores
        {
            get
            {
                return _highScores;
            }
        }

        private void OnHighScoreAdded(HighScore highScore)
        {
            highScore.Game = this;
        }

        private void OnHighScoreRemoved(HighScore highScore)
        {
            highScore.Game = null;
        }
        #endregion

        #region Version

        private int _version;

        public int Version
        {
            get
            {
                return _version;
            }
            set
            {
                if (_version != value)
                {
                    NotifyPropertyChanging("Version");
                    _version = value;
                    NotifyPropertyChanged("Version");
                }
            }
        }
        #endregion

        #region ListOfChanges

        private string _listOfChanges;

        public string ListOfChanges
        {
            get
            {
                return _listOfChanges;
            }
            set
            {
                if (_listOfChanges != value)
                {
                    NotifyPropertyChanging("ListOfChanges");
                    _listOfChanges = value;
                    NotifyPropertyChanged("ListOfChanges");
                }
            }
        }
        #endregion
    }
}
