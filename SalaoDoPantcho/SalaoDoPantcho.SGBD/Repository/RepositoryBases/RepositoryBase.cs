using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Transactions;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.SGBD.Context;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryBases
{
    public abstract class RepositoryBase<TEntity, TKey> : IDisposable, IContractsSGBDBase<TEntity, TKey> where TEntity : class
                                                                                                         where TKey : struct
    {
        #region Atributo

        protected DataContext dataContext;
        protected DbContextTransaction transacaoBD;

        #endregion

        #region Construtor

        public RepositoryBase()
        {
            dataContext = new DataContext();
        }

        #endregion

        #region Implementação Métodos Persistentes

        public void InserirPersistence(TEntity entidade)
        {
            if (entidade != null)
            {
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entidade).State = EntityState.Added;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                    throw new Exception(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public void AtualizarPersistence(TEntity entidade)
        {
            if(entidade != null)
            { 
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entidade).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                    }
                    throw new DbUpdateException(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public void ExcluirPersistence(TEntity entidade)
        {
            if (entidade != null)
            {
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entidade).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                    }
                    throw new DbUpdateException(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public ICollection<TEntity> PesquisarTodosPersistence()
        {
            try
            {
                List<TEntity> entidade = dataContext.Set<TEntity>().AsParallel().ToList();
                return entidade;
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public TEntity PesquisarPorIdPersistence(Int32 id)
        {
            if (id != 0)
            {
                try
                {
                    TEntity entidade = dataContext.Set<TEntity>().Find(id);
                    return entidade;
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                return null;
            }
        }

        #endregion

        #region Implementação da Interface IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources

            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}