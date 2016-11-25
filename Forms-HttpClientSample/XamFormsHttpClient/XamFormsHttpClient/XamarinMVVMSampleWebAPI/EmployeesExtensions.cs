﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using XamFormsHttpClient;
using XamFormsHttpClient.Models;

namespace XamFormsHttpClient
{
    public static partial class EmployeesExtensions
    {
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Employee DeleteEmployee(this IEmployees operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmployees)s).DeleteEmployeeAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Employee> DeleteEmployeeAsync(this IEmployees operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamFormsHttpClient.Models.Employee> result = await operations.DeleteEmployeeWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Employee GetEmployee(this IEmployees operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmployees)s).GetEmployeeAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Employee> GetEmployeeAsync(this IEmployees operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamFormsHttpClient.Models.Employee> result = await operations.GetEmployeeWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        public static IList<Employee> GetEmployees(this IEmployees operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmployees)s).GetEmployeesAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Employee>> GetEmployeesAsync(this IEmployees operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<XamFormsHttpClient.Models.Employee>> result = await operations.GetEmployeesWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='employee'>
        /// Required.
        /// </param>
        public static Employee PostEmployee(this IEmployees operations, Employee employee)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmployees)s).PostEmployeeAsync(employee);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='employee'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Employee> PostEmployeeAsync(this IEmployees operations, Employee employee, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamFormsHttpClient.Models.Employee> result = await operations.PostEmployeeWithOperationResponseAsync(employee, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='employee'>
        /// Required.
        /// </param>
        public static object PutEmployee(this IEmployees operations, int id, Employee employee)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmployees)s).PutEmployeeAsync(id, employee);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamFormsHttpClient.IEmployees.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='employee'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutEmployeeAsync(this IEmployees operations, int id, Employee employee, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutEmployeeWithOperationResponseAsync(id, employee, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
