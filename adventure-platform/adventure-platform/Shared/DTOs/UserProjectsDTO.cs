using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.DTOs
{
    public class UserProjectsDTO
    {
        
        public int Page { get; set; } = 1;
        public int NumPerPage { get; set; } = 12;
        public PaginationDTO Pagination
        {
            get
            {
                return new PaginationDTO()
                {
                    Page = Page,
                    NumPerPage = NumPerPage
                };
            }
        }

        public string UserEmail { get; set; }
    }
}
