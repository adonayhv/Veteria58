﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Veteria58.Common.Models
{
  public  class OwnerResponse
    {
        public int   Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Document { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<PetResponse> Pets { get; set; }

    }
}
