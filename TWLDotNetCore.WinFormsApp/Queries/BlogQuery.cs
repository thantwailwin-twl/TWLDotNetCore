﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWLDotNetCore.WinFormsApp.Queries
{
    public class BlogQuery
    {
        public static string CreateBlog { get; } = @"INSERT INTO [dbo].[Tbl_Blog]
                                   ([BlogTitle]
                                   ,[BlogAuthor]
                                   ,[BlogContent])
                             VALUES
                                   (@BlogTitle
                                   ,@BlogAuthor
                                   ,@BlogContent)";

        public static string SelectBlog { get; } = @"SELECT[BlogId]
                                                          ,[BlogTitle]
                                                          ,[BlogAuthor]
                                                          ,[BlogContent]
                                                    FROM[dbo].[Tbl_Blog]";

        public static string UpdateBlog { get; } = @"UPDATE [dbo].[Tbl_Blog]
                                                   SET [BlogTitle] = @BlogTitle
                                                      ,[BlogAuthor] = @BlogAuthor
                                                      ,[BlogContent] = @BlogContent
                                                 WHERE BlogId = @BlogId";

        public static string DeleteBlog { get; } = @"DELETE FROM[dbo].[Tbl_Blog]
                                                    WHERE BlogId = @BlogId";
    }
}

