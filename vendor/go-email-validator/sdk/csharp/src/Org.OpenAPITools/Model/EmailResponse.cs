/* 
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EmailResponse
    /// </summary>
    [DataContract]
    public partial class EmailResponse :  IEquatable<EmailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResponse" /> class.
        /// </summary>
        /// <param name="checkIfEmailExist">checkIfEmailExist.</param>
        /// <param name="mailboxvalidator">mailboxvalidator.</param>
        /// <param name="promptEmailVerificationApi">promptEmailVerificationApi.</param>
        public EmailResponse(CheckIfEmailExistResult checkIfEmailExist = default(CheckIfEmailExistResult), MailboxvalidatorResult mailboxvalidator = default(MailboxvalidatorResult), PromptEmailVerificationApiResult promptEmailVerificationApi = default(PromptEmailVerificationApiResult))
        {
            this.CheckIfEmailExist = checkIfEmailExist;
            this.Mailboxvalidator = mailboxvalidator;
            this.PromptEmailVerificationApi = promptEmailVerificationApi;
        }
        
        /// <summary>
        /// Gets or Sets CheckIfEmailExist
        /// </summary>
        [DataMember(Name="check_if_email_exist", EmitDefaultValue=false)]
        public CheckIfEmailExistResult CheckIfEmailExist { get; set; }

        /// <summary>
        /// Gets or Sets Mailboxvalidator
        /// </summary>
        [DataMember(Name="mailboxvalidator", EmitDefaultValue=false)]
        public MailboxvalidatorResult Mailboxvalidator { get; set; }

        /// <summary>
        /// Gets or Sets PromptEmailVerificationApi
        /// </summary>
        [DataMember(Name="prompt_email_verification_api", EmitDefaultValue=false)]
        public PromptEmailVerificationApiResult PromptEmailVerificationApi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailResponse {\n");
            sb.Append("  CheckIfEmailExist: ").Append(CheckIfEmailExist).Append("\n");
            sb.Append("  Mailboxvalidator: ").Append(Mailboxvalidator).Append("\n");
            sb.Append("  PromptEmailVerificationApi: ").Append(PromptEmailVerificationApi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailResponse);
        }

        /// <summary>
        /// Returns true if EmailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckIfEmailExist == input.CheckIfEmailExist ||
                    (this.CheckIfEmailExist != null &&
                    this.CheckIfEmailExist.Equals(input.CheckIfEmailExist))
                ) && 
                (
                    this.Mailboxvalidator == input.Mailboxvalidator ||
                    (this.Mailboxvalidator != null &&
                    this.Mailboxvalidator.Equals(input.Mailboxvalidator))
                ) && 
                (
                    this.PromptEmailVerificationApi == input.PromptEmailVerificationApi ||
                    (this.PromptEmailVerificationApi != null &&
                    this.PromptEmailVerificationApi.Equals(input.PromptEmailVerificationApi))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CheckIfEmailExist != null)
                    hashCode = hashCode * 59 + this.CheckIfEmailExist.GetHashCode();
                if (this.Mailboxvalidator != null)
                    hashCode = hashCode * 59 + this.Mailboxvalidator.GetHashCode();
                if (this.PromptEmailVerificationApi != null)
                    hashCode = hashCode * 59 + this.PromptEmailVerificationApi.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}