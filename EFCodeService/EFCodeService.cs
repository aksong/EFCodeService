using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace EFCodeService
{
    public class EFCodeService
    {
        internal const int MaxStringLength = 10;
        const int MAX_TRIES = 50;
        DbContext _context;
        int _codeLength;
        public EFCodeService(DbContext context, int codeLength)
        {
            _context = context;
            _codeLength = codeLength;
        }

        public string GenerateSlug(string title)
        {
            return title.GenerateSlug();
        }

        public string GenerateCode()
        {
            int counter = 0;
            var dbset = _context.Set(typeof(EFCode));
			while (true) {
				var code = Utilities.GenerateRandomString(_codeLength);
					dbset.Add(new EFCode { Code = code });
					try {
						_context.SaveChanges();
                        return code;
					} catch {
                        if (counter++ > MAX_TRIES)
                            return null;

					}
				}
		}


    }
}
