﻿using Discord;
using System;

namespace Thirain.MessageExtension
{
    public static class MessageExtension
    {
        public static bool HasCharPrefix(this IUserMessage msg, char c, ref int argPos)
        {
            var text = msg.Content;
            if (!string.IsNullOrEmpty(text) && text[0] == c)
            {
                argPos = 1;
                return true;
            }
            return false;
        }

        public static bool HasStringPrefix(this IUserMessage msg, string str, ref int argPos, StringComparison comparisonType = StringComparison.Ordinal)
        {
            var text = msg.Content;
            if (!string.IsNullOrEmpty(text) && text.StartsWith(str, comparisonType))
            {
                argPos = str.Length;
                return true;
            }
            return false;
        }

        public static bool HasMentionPrefix(this IUserMessage msg, IUser user, ref int argPos)
        {
            var text = msg.Content;
            if (string.IsNullOrEmpty(text) || text.Length <= 3 || text[0] != '<' || text[1] != '@') return false;

            int endPos = text.IndexOf('>');
            if (endPos == -1) return false;
            if (text.Length < endPos + 2 || text[endPos + 1] != ' ') return false; //Must end in "> "

            if (!MentionUtils.TryParseUser(text.Substring(0, endPos + 1), out ulong userId)) return false;
            if (userId == user.Id)
            {
                argPos = endPos + 2;
                return true;
            }
            return false;
        }
    }
}
