﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Editor
{
    internal struct SignatureHelpTriggerInfo
    {
        public SignatureHelpTriggerReason TriggerReason { get; private set; }
        public char? TriggerCharacter { get; private set; }

        internal SignatureHelpTriggerInfo(SignatureHelpTriggerReason triggerReason, char? triggerCharacter = null)
            : this()
        {
            Contract.ThrowIfTrue(triggerReason == SignatureHelpTriggerReason.TypeCharCommand && triggerCharacter == null);
            this.TriggerReason = triggerReason;
            this.TriggerCharacter = triggerCharacter;
        }
    }
}
