using BlogEngine.App.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEnginte.Tests.Mocks
{
    public static class RepositoryMocks
    {
        public static Mock<IPostRepository> GetPostRepository()
        {
            var Posts = new List<Post> { 
                new Post
                {
                    Id = 1,
                    Author = "erickvazquezi",
                    IsActive= true,
                    Content = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                    CreateDate= DateTime.Now,
                    Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    HeaderImage = "https://picsum.photos/800/500",
                    Order = 1,
                    PostImage = "https://picsum.photos/800/500",
                    Title= "Lorem Ipsum",
                }
            };

            var mockPostRepository = new Mock<IPostRepository>();
            mockPostRepository.Setup(repo => repo.GetAllPosts()).Returns(Posts);
            mockPostRepository.Setup(repo => repo.GetPostById(It.IsAny<int>())).Returns(Posts[0]);

            return mockPostRepository;
        }
    }
}
