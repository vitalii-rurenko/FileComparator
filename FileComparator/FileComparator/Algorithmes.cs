using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparator
{
    /// <summary>
    /// Перечисление, которое содержит поддерживаемые хеш-алгоритмы.
    /// </summary>
    public enum Algorithmes : int
    {
        CRC32,
        MD5,
        RIPEMD160,
        SHA1,
        SHA256,
        KECCAK224,
        KECCAK256,
        KECCAK384,
        KECCAK512
    }
}
