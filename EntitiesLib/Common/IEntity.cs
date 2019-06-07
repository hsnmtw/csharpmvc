using System;

namespace MVCHIS.Common {
    public interface IEntity {
        MetaData MetaData { get; }
        string GetDDL();
        void ValidateMetaData(Type M);
    }
}
