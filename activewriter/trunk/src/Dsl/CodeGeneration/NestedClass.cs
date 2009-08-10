// Copyright 2006 Gokhan Altinoren - http://altinoren.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Altinoren.ActiveWriter
{
    public partial class NestedClass
    {
        #region Public Code Generation Methods

        public bool DoesImplementINotifyPropertyChanged()
        {
            return (this.Model.ImplementINotifyPropertyChanged && this.ImplementINotifyPropertyChanged == InheritableBoolean.Inherit) ||
                this.ImplementINotifyPropertyChanged == InheritableBoolean.True;
        }

        public bool DoesImplementINotifyPropertyChanging()
        {
            return (this.Model.ImplementINotifyPropertyChanging && this.ImplementINotifyPropertyChanging == InheritableBoolean.Inherit) ||
                this.ImplementINotifyPropertyChanging == InheritableBoolean.True;
        }

        public bool HasPropertyWithValidators()
        {
            return Properties.Find(property => property.IsValidatorSet()) != null;
        }

        public PropertyAccess EffectiveAccess
        {
            get
            {
                return Model.Access;
            }
        }

        #endregion

    }
}
