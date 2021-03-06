﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

namespace OpenTrans.net
{
    /**
     * @todo add missing attribute: Phone, Fax (typed), page 62 of spec
     */
    public class Contact
    {
        public string Id { get; set; }
        /// <summary>
        /// Nachname des Ansprechpartners
        /// </summary>
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string AcademicTitle { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public string Description { get; set; }
        public string Url { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public List<string> EmailAddresses { get; set; } = new List<string>();
        public string Authentification { get; set; }
    }
}