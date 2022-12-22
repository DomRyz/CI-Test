﻿using Aboriginal_Art_Gallery_of_Australia.Models.DTOs;
using static Aboriginal_Art_Gallery_of_Australia.Models.DTOs.UserInputDto;
using static Aboriginal_Art_Gallery_of_Australia.Models.DTOs.UserOutputDto;

namespace Aboriginal_Art_Gallery_of_Australia.Persistence.Interfaces
{
    public interface IUserDataAccess
    {
        /// <summary>
        /// Retrieves a complete list of users from the database/repository.
        /// </summary>
        /// <returns>Returns the collection of user as a list.</returns>
        List<UserOutputDto> GetUsers();

        /// <summary>
        /// Retrieves the user matching the specified ID from the database/repository.
        /// </summary>
        /// <returns>Returns the matching user if successful or null if unsuccessful.</returns>
        UserOutputDto? GetUserById(int id);

        /// <summary>
        /// Inserts an user into the database/repository.
        /// </summary>
        /// <param name="user">The new user to be inserted.</param>
        /// <returns>Returns a copy of the inserted user if successful or null if unsuccessful.</returns>
        UserInputDto? InsertUser(UserInputDto user);

        /// <summary>
        /// Updates the user matching the specified ID in the database/repository.
        /// </summary>
        /// <param name="user">The updated user details</param>
        /// <returns>Returns a copy of the updated user if successful or null if unsuccessful.</returns>
        UserInputDto? UpdateUser(int id, UserInputDto user);

        /// <summary>
        /// Delete the user matching the specified ID from the database/repository.
        /// </summary>
        /// <param name="id">The specified user ID to be matched.</param>
        /// <returns>Returns the result of the delete operation as a boolean value.</returns>
        bool DeleteUser(int id);

        /// <summary>
        /// Authenticates the user by verifying the submitted login information.
        /// </summary>
        /// <param name="login">The user login to be authenticated.</param>
        /// <returns>Returns the user output with the password hash as a blank string.</returns>
        Tuple<UserOutputDto, string>? AuthenticateUser(LoginDto login);
    }
}