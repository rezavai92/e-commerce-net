
using Application.shared.Enums;

namespace Application.shared.Models
{
    public record GenericSearchFilter(
          string SearchKey,
          string SortBy,
          SortDirection Sortdireciton,
          int PageSize=10,
          int PageNo=0
        );
}
