using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoard.MockData;
using ScrumBoardLib.model;

namespace ScrumBoard.Services
{
    public class UserStoryService
    {
        private readonly List<UserStory> _userStories;

        public UserStoryService()
        {
            _userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return new List<UserStory>(_userStories);
        }
    }
}
