/**
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The PromptEmailVerificationApiMX model module.
 * @module model/PromptEmailVerificationApiMX
 * @version 0.0.1
 */
class PromptEmailVerificationApiMX {
    /**
     * Constructs a new <code>PromptEmailVerificationApiMX</code>.
     * @alias module:model/PromptEmailVerificationApiMX
     */
    constructor() { 
        
        PromptEmailVerificationApiMX.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>PromptEmailVerificationApiMX</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/PromptEmailVerificationApiMX} obj Optional instance to populate.
     * @return {module:model/PromptEmailVerificationApiMX} The populated <code>PromptEmailVerificationApiMX</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new PromptEmailVerificationApiMX();

            if (data.hasOwnProperty('accepts_mail')) {
                obj['accepts_mail'] = ApiClient.convertToType(data['accepts_mail'], 'Boolean');
            }
            if (data.hasOwnProperty('records')) {
                obj['records'] = ApiClient.convertToType(data['records'], ['String']);
            }
        }
        return obj;
    }


}

/**
 * @member {Boolean} accepts_mail
 */
PromptEmailVerificationApiMX.prototype['accepts_mail'] = undefined;

/**
 * @member {Array.<String>} records
 */
PromptEmailVerificationApiMX.prototype['records'] = undefined;






export default PromptEmailVerificationApiMX;
