﻿namespace SoundCloudExplode.Exceptions;

/// <summary>
/// Exception thrown when the requested playlist is unavailable.
/// </summary>
public class PlaylistUnavailableException : SoundCloudExplodeException
{
    /// <summary>
    /// Initializes an instance of <see cref="PlaylistUnavailableException"/>.
    /// </summary>
    public PlaylistUnavailableException(string message) : base(message)
    {
    }
}