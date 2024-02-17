using Application.shared.Enums;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;

namespace Application.UAM.Queries
{
    public sealed record GetUserByIdQuery(string ItemId) : IQuery;

    public sealed record GetUsersByFilterQuery : GenericSearchFilter
    {
        public GetUsersByFilterQuery(
            string searchKey,
            string sortBy,
            SortDirection sortDirection,
            int pageSize = 10,
            int pageNo = 0
       ) : base(searchKey, sortBy, sortDirection, pageSize, pageNo)
            {
            }
        }
    }
