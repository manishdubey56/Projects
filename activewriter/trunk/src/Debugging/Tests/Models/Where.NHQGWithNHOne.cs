//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    
    
    public partial class Where {
        
        /// <summary>
        /// Query helper for member Where.NHQGWithNHOne
        /// </summary>
        public static Root_Query_NHQGWithNHOne NHQGWithNHOne {
            get {
                return new Root_Query_NHQGWithNHOne();
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Query_NHQGWithNHOne
        /// </summary>
        public partial class Query_NHQGWithNHOne<T1> : Query.QueryBuilder<T1>
         {
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHOne..ctor
            /// </summary>
            public Query_NHQGWithNHOne(string name, string associationPath) : 
                    base(name, associationPath) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHOne..ctor
            /// </summary>
            public Query_NHQGWithNHOne(string name, string associationPath, bool backTrackAssociationOnEquality) : 
                    base(name, associationPath, backTrackAssociationOnEquality) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHOne.
            /// </summary>
            public virtual Query.PropertyQueryBuilder<T1> Name {
                get {
                    string temp = associationPath;
                    return new Query.PropertyQueryBuilder<T1>("Name", temp);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHOne.
            /// </summary>
            public virtual Query.QueryBuilder<T1> Id {
                get {
                    string temp = associationPath;
                    return new Query.QueryBuilder<T1>("Id", temp);
                }
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Root_Query_NHQGWithNHOne
        /// </summary>
        public partial class Root_Query_NHQGWithNHOne : Query_NHQGWithNHOne<Debugging.Tests.NHQGWithNHOne> {
            
            /// <summary>
            /// Query helper for member Root_Query_NHQGWithNHOne..ctor
            /// </summary>
            public Root_Query_NHQGWithNHOne() : 
                    base("this", null) {
            }
        }
    }
    
    public partial class OrderBy {
        
        /// <summary>
        /// Query helper for member OrderBy.NHQGWithNHOne
        /// </summary>
        public partial class NHQGWithNHOne {
            
            /// <summary>
            /// Query helper for member NHQGWithNHOne.Name
            /// </summary>
            public static Query.OrderByClause Name {
                get {
                    return new Query.OrderByClause("Name");
                }
            }
            
            /// <summary>
            /// Query helper for member NHQGWithNHOne.Id
            /// </summary>
            public static Query.OrderByClause Id {
                get {
                    return new Query.OrderByClause("Id");
                }
            }
        }
    }
    
    public partial class ProjectBy {
        
        /// <summary>
        /// Query helper for member ProjectBy.NHQGWithNHOne
        /// </summary>
        public partial class NHQGWithNHOne {
            
            /// <summary>
            /// Query helper for member NHQGWithNHOne.Name
            /// </summary>
            public static Query.PropertyProjectionBuilder Name {
                get {
                    return new Query.PropertyProjectionBuilder("Name");
                }
            }
        }
    }
    
    public partial class GroupBy {
        
        /// <summary>
        /// Query helper for member GroupBy.NHQGWithNHOne
        /// </summary>
        public partial class NHQGWithNHOne {
            
            /// <summary>
            /// Query helper for member NHQGWithNHOne.Name
            /// </summary>
            public static NHibernate.Expression.IProjection Name {
                get {
                    return NHibernate.Expression.Projections.GroupProperty("Name");
                }
            }
        }
    }
}