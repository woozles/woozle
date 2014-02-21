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
    public partial class StatusRepository  : AbstractRepository<Status>
    {
    
    	public StatusRepository(IEfUnitOfWork Context) : base(Context)
    	{
    	}
    
    
    	 public override Status Synchronize(Status entity, SessionData sessionData) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, sessionData);
    			
    			attachedObj.StatusField = Context.SynchronizeObject(entity.StatusField, sessionData); 
    
    			attachedObj.Translation = Context.SynchronizeObject(entity.Translation, sessionData); 
    
    			
    			//Navigation Property 'People'
    			stopwatch.Start();
    			foreach(var n in entity.People.Where(n => n.PersistanceState == PState.Added))
    			{ 
    				if (!attachedObj.People.Contains(n)) attachedObj.People.Add(n);
    				if (n is IMandatorCapable)
    				{
    					n.MandatorId = sessionData.Mandator.Id;
    				}
    			} 
    			foreach(var n in entity.People.Where(n => n.PersistanceState == PState.Modified || n.PersistanceState == PState.Deleted))
    			{ 
    					Context.SynchronizeObject(n, sessionData); 
    			} 
    			stopwatch.Stop();
    			this.Logger.Info(string.Format("Synchronize state of '{0}', took {1} ms", "People", stopwatch.ElapsedMilliseconds));
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
