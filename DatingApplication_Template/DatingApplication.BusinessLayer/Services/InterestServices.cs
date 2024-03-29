﻿using DatingApplication.BusinessLayer.Interfaces;
using DatingApplication.BusinessLayer.Services.Repository;
using DatingApplication.BusinessLayer.ViewModels;
using DatingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.Services
{
    public class InterestServices : IInterestServices
    {
        private readonly IInterestRepository _interestRepository;
        public InterestServices(IInterestRepository interestRepository)
        {
            _interestRepository = interestRepository;
        }

        public async Task<Interests> FindInterestById(long interestId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Interests>> FindInterestByUserId(long userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Interests> Register(Interests interests)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Interests> UpdateInterest(InterestViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
