using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.DTOs
{
    public class AdventureFilterDTO
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

        public int GenreID {get; set;}
    }
}
