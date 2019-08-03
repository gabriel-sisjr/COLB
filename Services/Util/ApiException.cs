﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Services.Util
{
    /// <summary>
    /// Exceção customizada para uso interno da api
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Status Code
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Lista de erros de validação a ser mostrada para o usuário
        /// </summary>
        public List<String> ValidationErrors { get; }

        /// <summary>
        /// Informação a ser logada
        /// </summary>
        public String LogInfo { get; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="statusCode"></param>
        public ApiException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="validationErrors"></param>
        public ApiException(HttpStatusCode statusCode, List<String> validationErrors)
        {
            StatusCode = statusCode;
            ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="logInfo"></param>
        public ApiException(HttpStatusCode statusCode, String logInfo) : base(logInfo)
        {
            StatusCode = statusCode;
            LogInfo = logInfo;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="validationErrors"></param>
        /// <param name="logInfo"></param>
        public ApiException(HttpStatusCode statusCode, List<String> validationErrors, String logInfo) : base(logInfo)
        {
            StatusCode = statusCode;
            ValidationErrors = validationErrors;
            LogInfo = logInfo;
        }

        /// <summary>
        /// Adiciona um erro na lista de erros de validação
        /// </summary>
        /// <param name="error"></param>
        public void AddError(String error)
        {
            ValidationErrors.Add(error);
        }
    }
}