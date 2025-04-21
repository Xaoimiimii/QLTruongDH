using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongDH
{
    public class PrivilegeState
    {
        public bool WithGrantOption { get; set; }
        public List<string> Columns { get; set; }

        public PrivilegeState(bool withGrantOption, List<string> columns)
        {
            WithGrantOption = withGrantOption;
            Columns = columns ?? new List<string>();
        }

        public override bool Equals(object obj)
        {
            if (obj is not PrivilegeState other) return false;

            return WithGrantOption == other.WithGrantOption &&
                   Columns.OrderBy(c => c).SequenceEqual(other.Columns.OrderBy(c => c));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(WithGrantOption, string.Join(",", Columns.OrderBy(c => c)));
        }
    }

    public interface ILogoutable
    {
        event Action LogoutRequested;
    }


}
