//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    
    
    public partial class Where {
        
        /// <summary>
        /// Query helper for member Where.NHQGWithNHMany
        /// </summary>
        public static Root_Query_NHQGWithNHMany NHQGWithNHMany {
            get {
                return new Root_Query_NHQGWithNHMany();
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Query_NHQGWithNHMany
        /// </summary>
        public partial class Query_NHQGWithNHMany<T1> : Query.QueryBuilder<T1>
         {
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHMany..ctor
            /// </summary>
            public Query_NHQGWithNHMany(string name, string associationPath) : 
                    base(name, associationPath) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHMany..ctor
            /// </summary>
            public Query_NHQGWithNHMany(string name, string associationPath, bool backTrackAssociationOnEquality) : 
                    base(name, associationPath, backTrackAssociationOnEquality) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHMany.
            /// </summary>
            public virtual Query.PropertyQueryBuilder<T1> Name {
                get {
                    string temp = associationPath;
                    return new Query.PropertyQueryBuilder<T1>("Name", temp);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHMany.
            /// </summary>
            public virtual Query.QueryBuilder<T1> Id {
                get {
                    string temp = associationPath;
                    return new Query.QueryBuilder<T1>("Id", temp);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithNHMany.
            /// </summary>
            public virtual Query_NHQGWithNHOne<T1> NHQGWithNHOne {
                get {
                    string temp = associationPath;
                    temp = ((temp + ".") 
                                + "NHQGWithNHOne");
                    return new Query_NHQGWithNHOne<T1>("NHQGWithNHOne", temp, true);
                }
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Root_Query_NHQGWithNHMany
        /// </summary>
        public partial class Root_Query_NHQGWithNHMany : Query_NHQGWithNHMany<Debugging.Tests.NHQGWithNHMany> {
            
            /// <summary>
            /// Query helper for member Root_Query_NHQGWithNHMany..ctor
            /// </summary>
            public Root_Query_NHQGWithNHMany() : 
                    base("this", null) {
            }
        }
    }
    
    public partial class OrderBy {
        
        /// <summary>
        /// Query helper for member OrderBy.NHQGWithNHMany
        /// </summary>
        public partial class NHQGWithNHMany {
            
            /// <summary>
            /// Query helper for member NHQGWithNHMany.Name
            /// </summary>
            public static Query.OrderByClause Name {
                get {
                    return new Query.OrderByClause("Name");
                }
            }
            
            /// <summary>
            /// Query helper for member NHQGWithNHMany.Id
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
        /// Query helper for member ProjectBy.NHQGWithNHMany
        /// </summary>
        public partial class NHQGWithNHMany {
            
            /// <summary>
            /// Query helper for member NHQGWithNHMany.Name
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
        /// Query helper for member GroupBy.NHQGWithNHMany
        /// </summary>
        public partial class NHQGWithNHMany {
            
            /// <summary>
            /// Query helper for member NHQGWithNHMany.Name
            /// </summary>
            public static NHibernate.Expression.IProjection Name {
                get {
                    return NHibernate.Expression.Projections.GroupProperty("Name");
                }
            }
        }
    }
}
