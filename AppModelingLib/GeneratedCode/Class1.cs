﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан инструментальным средством
//     В случае повторного создания кода изменения, внесенные в этот файл, будут потеряны.
// </auto-generated>
//------------------------------------------------------------------------------
using SqlDBConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public class Class1 : GenericRepository<TContext, TEntity>, IErrorListRepository
{
	public virtual void FindByErrorCode()
	{
		throw new System.NotImplementedException();
	}

	public override IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties)
	{
		throw new System.NotImplementedException();
	}

	public override TEntity GetByID(Object id)
	{
		throw new System.NotImplementedException();
	}

	public override void Insert(TEntity entity)
	{
		throw new System.NotImplementedException();
	}

	public override void Delete(Object id)
	{
		throw new System.NotImplementedException();
	}

	public override void Delete(TEntity entityToDelete)
	{
		throw new System.NotImplementedException();
	}

	public override void Update(TEntity entityToUpdate)
	{
		throw new System.NotImplementedException();
	}

}

