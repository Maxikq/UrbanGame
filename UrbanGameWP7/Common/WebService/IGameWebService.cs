﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Interfece responsible for communication with the web server
    /// </summary>
    public interface IGameWebService
    {
        /// <summary>
        /// Method responses for signing up user into the game
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <returns>a bool</returns>
        Task<bool> JoinGame(int gid);

        /// <summary>
        /// Method responses for leaving the game
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <returns>a bool</returns>
        Task<bool> LeaveGame(int gid);

        /// <summary>
        /// Returns state of game
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <returns></returns>
        Task<GameOverResponse> CheckGameOver(int gid);

        /// <summary>
        /// Returns completely filled in IGame
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <returns></returns>
        Task<IGame> GetGameInfo(int gid);

        /// <summary>
        /// Method returns an array of game's tasks
        /// </summary>
        /// <returns>Array of ITask</returns>
        Task<ITask[]> GetTasks(int gid);

        /// <summary>
        /// Returns task's details
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <param name="tid">Integer parameter - task's identifier</param>
        /// <returns>Task's details</returns>
        Task<ITask> GetTaskDetails(int gid, int tid);

        /// <summary>
        /// Returns task's details (generic version)
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <param name="tid">Integer parameter - task's identifier</param>
        /// <returns>Task's details</returns>
        Task<TTaskType> GetTaskDetails<TTaskType>(int gid, int tid) where TTaskType : ITask;

        /// <summary>
        /// Sends solution to the web server
        /// </summary>
        /// <param name="gid">Integer parameter - game's identifier</param>
        /// <param name="tid">Integer parameter - task's identifier</param>
        /// <param name="solution">Solution of task</param>
        /// <returns>a bool</returns>
        Task<SolutionResultScore> SubmitTaskSolution(int gid, int tid, IBaseSolution solution);

        /// <summary>
        /// Method responses for user authorization
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns>a bool</returns>
        Task<AuthorizeState> Authorize(string username, string password);


        /// <summary>
        /// Creates account
        /// </summary>
        Task<CreateAccountResponse> CreateAccount(string username, string email, string password);

        /// <summary>
        /// Method returns array of the nearest games(only needed fields filled in)
        /// </summary>
        /// <returns></returns>
        Task<IGame[]> UserNearbyGames(GeoCoordinate coordinate);

        /// <summary>
        /// Method returns array of alerts
        /// </summary>
        /// <returns></returns>
        IAlert[] Alerts();

        /// <summary>
        /// Method returns array of high scores
        /// </summary>
        /// <returns></returns>
        IHighScore[] HighScores();

        /// <summary>
        /// Method returns status and points of submitted solution
        /// </summary>
        /// <returns></returns>
        Task<SolutionStatusResponse> GetSolutionStatus(int taskId);
    }
}
