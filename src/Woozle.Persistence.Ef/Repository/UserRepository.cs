//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics;
using System;
using System.Linq;
using System.Collections.Generic;
using Woozle.Model;
using Woozle.Model.SessionHandling;

namespace Woozle.Persistence.Ef.Repository
{
    public partial class UserRepository  : AbstractRepository<User>
    {
    
    	public UserRepository(IEfUnitOfWork Context) : base(Context)
    	{
    	}
    
    
    	 public override User Synchronize(User entity, SessionData sessionData) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, sessionData);
    			
    			attachedObj.Language = Context.SynchronizeObject(entity.Language, sessionData); 
    
    			attachedObj.Status = Context.SynchronizeObject(entity.Status, sessionData); 
    
    			
    			//Navigation Property 'UserMandatorRoles'
    			stopwatch.Start();
    			foreach(var n in entity.UserMandatorRoles.Where(n => n.PersistanceState == PState.Added))
    			{ 
    				if (!attachedObj.UserMandatorRoles.Contains(n)) attachedObj.UserMandatorRoles.Add(n);
    				if (n is IMandatorCapable)
    				{
    					n.MandatorId = sessionData.Mandator.Id;
    				}
    			} 
    			foreach(var n in entity.UserMandatorRoles.Where(n => n.PersistanceState == PState.Modified || n.PersistanceState == PState.Deleted))
    			{ 
    					Context.SynchronizeObject(n, sessionData); 
    			} 
    			stopwatch.Stop();
    			this.Logger.Info(string.Format("Synchronize state of '{0}', took {1} ms", "UserMandatorRoles", stopwatch.ElapsedMilliseconds));
    			return attachedObj; 
    		}
    		catch (Exception e)
    		{
    			this.Logger.Error(e.Message); 
    			throw new PersistenceException(PersistenceOperation.SYNCHRONIZE, e); 
    		} 
         } 
    
    }
    
}
