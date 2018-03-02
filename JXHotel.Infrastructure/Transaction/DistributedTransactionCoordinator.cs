﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JXHotel.Infrastructure.Transaction
{
    /// <summary>
    /// DTC事务
    /// </summary>
    internal sealed class DistributedTransactionCoordinator : TransactionCoordinator
    {
        private readonly TransactionScope scope = new TransactionScope();

        public DistributedTransactionCoordinator(params IUnitWork[] unitWorks)
            : base(unitWorks)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                scope.Dispose();
        }


        public override void Commit()
        {
            base.Commit();
            scope.Complete();
        }

    }
}
