using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.SGBD.Context;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryBases
{
    public abstract class RepositoryBase<TEntity, TKey> : IContractsSGBDBase<TEntity, TKey> where TEntity : class
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
            try
            {
                transacaoBD = dataContext.Database.BeginTransaction();               
                dataContext.Entry(entidade).State = EntityState.Added;                
                dataContext.SaveChanges();
                transacaoBD.Commit();
                transacaoBD.Dispose();
                dataContext.Dispose();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                }
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
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
                throw new NotSupportedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public void AtualizarPersistence(TEntity entidade)
        {
            try
            {
                transacaoBD = dataContext.Database.BeginTransaction();
                dataContext.Entry(entidade).State = EntityState.Modified;
                dataContext.SaveChanges();
                transacaoBD.Commit();
                transacaoBD.Dispose();
                dataContext.Dispose();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                }
                throw new DbUpdateException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
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
                throw new NotSupportedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
            finally
            {
                dataContext.Dispose();
                transacaoBD.Dispose();
            }
        }

        public void ExcluirPersistence(TEntity entidade)
        {
            try
            {
                transacaoBD = dataContext.Database.BeginTransaction();
                dataContext.Entry(entidade).State = EntityState.Deleted;
                dataContext.SaveChanges();
                transacaoBD.Commit();
                transacaoBD.Dispose();
                dataContext.Dispose();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                }
                throw new DbUpdateException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
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
                throw new NotSupportedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public ICollection<TEntity> PesquisarTodosPersistence()
        {
            try
            {
                List<TEntity> entidade = dataContext.Set<TEntity>().AsNoTracking().ToList();
                return entidade;
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public TEntity PesquisarPorIdPersistence(Int32 id)
        {
            try
            {
                TEntity entidade = dataContext.Set<TEntity>().Find(id);
                return entidade;
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        #endregion
    }
}