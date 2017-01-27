﻿namespace Discord
{
    public enum GuildPermission : byte
    {
        //General
        CreateInstantInvite = 0,
        KickMembers = 1,
        BanMembers = 2,
        Administrator = 3,
<<<<<<< HEAD:src/Discord.Net.Core/Entities/Permissions/GuildPermission.cs
        ManageChannels = 4,
        ManageGuild = 5,
=======
        ManageChannel = 4,
        ManageServer = 5,
>>>>>>> refs/remotes/RogueException/master:src/Discord.Net/Enums/PermissionBits.cs

        //Text
        AddReactions = 6,
        ReadMessages = 10,
        SendMessages = 11,
        SendTTSMessages = 12,
        ManageMessages = 13,
        EmbedLinks = 14,
        AttachFiles = 15,
        ReadMessageHistory = 16,
        MentionEveryone = 17,
        UseExternalEmojis = 18,

        //Voice
        Connect = 20,
        Speak = 21,
        MuteMembers = 22,
        DeafenMembers = 23,
        MoveMembers = 24,
<<<<<<< HEAD:src/Discord.Net.Core/Entities/Permissions/GuildPermission.cs
        UseVAD = 25,

        //General2
        ChangeNickname = 26,
        ManageNicknames = 27,
        ManageRoles = 28,
        ManageWebhooks = 29,
        ManageEmojis = 30
=======
        UseVoiceActivation = 25,

        ChangeNickname = 26,
        ManageNicknames = 27,
        ManageRolesOrPermissions = 28,
>>>>>>> refs/remotes/RogueException/master:src/Discord.Net/Enums/PermissionBits.cs
    }
}
