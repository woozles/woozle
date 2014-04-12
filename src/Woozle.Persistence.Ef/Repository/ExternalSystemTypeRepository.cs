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
    public partial class ExternalSystemTypeRepository  : AbstractRepository<ExternalSystemType>
    {
    
    	public ExternalSystemTypeRepository(IEfUnitOfWork Context) : base(Context)
    	{
    	}
    
    
    	 public override ExternalSystemType Synchronize(ExternalSystemType entity, SessionData sessionData) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, sessionData);
    			
    			
    			//Navigation Property 'ExternalSystems'
    			stopwatch.Start();
    			foreach(var n in entity.ExternalSystems.Where(n => n.PersistanceState == PState.Added))
    			{ 
    				if (!attachedObj.ExternalSystems.Contains(n)) attachedObj.ExternalSystems.Add(n);
    				if (n is IMandatorCapable)
    				{
    					n.MandatorId = sessionData.Mandator.Id;
    				}
    			} 
    			foreach(var n in entity.ExternalSystems.Where(n => n.PersistanceState == PState.Modified || n.PersistanceState == PState.Deleted))
    			{ 
    					Context.SynchronizeObject(n, sessionData); 
    			} 
    			stopwatch.Stop();
    			Trace.TraceInformation(string.Format("Synchronize state of '{0}', took {1} ms", "ExternalSystems", stopwatch.ElapsedMilliseconds));
    			return attachedObj; 
    		}
    		catch (Exception e)
    		{
    			Trace.TraceError(e.Message); 
    			throw new PersistenceException(PersistenceOperation.SYNCHRONIZE, e); 
    		} 
         } 
    
    }
    
}
