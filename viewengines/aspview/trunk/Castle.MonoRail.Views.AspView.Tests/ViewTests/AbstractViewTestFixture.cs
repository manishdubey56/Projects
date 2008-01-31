#region license
// Copyright 2006-2007 Ken Egozi http://www.kenegozi.com/
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
#endregion

using System.Web;

namespace Castle.MonoRail.Views.AspView.Tests.ViewTests
{
	using System;
	using System.Collections;
	using System.IO;
	using Framework;
	using Framework.Services;
	using Framework.Test;
	using Xunit;
	using Stubs;
	using System.Collections.Generic;

	public abstract class AbstractViewTestFixture
	{
		protected IViewBaseInternal view;
		protected IDictionary propertyBag;
		protected Flash flash;
		protected StringWriter writer;
		protected AspViewEngine engine;
		protected IDictionary<string, HttpCookie> cookies;
		protected IMockRequest request;
		protected IMockResponse response;
		protected UrlInfo url;
		protected ITrace trace;
		protected IController controller;
		protected IControllerContext controllerContext;
		protected IEngineContext context;
		protected IUrlBuilder urlBuilder;
		protected IFilterFactory filterFactory;
		protected IViewEngineManager viewEngineManager;
		protected IActionSelector actionSelector;
		protected IMonoRailServices monoRailServices;
		protected string expected;

		public AbstractViewTestFixture()
		{
			SetUp();
		}

		public void SetUp()
		{
			Clear();

			CreateStubsAndMocks();

			CreateDefaultStubsAndMocks();
		}

		/// <summary>
		/// Creating test specific stubs and mocks
		/// </summary>
		protected virtual void CreateStubsAndMocks()
		{
		}

		protected void AddCompilation(string key, Type viewType)
		{
			string className = AspViewEngine.GetClassName(key);
			((IAspViewEngineTestAccess)engine).Compilations.Add(className, viewType);
		}

		/// <summary>
		/// Creating default stub and mocks
		/// </summary>
		protected virtual void CreateDefaultStubsAndMocks()
		{
			writer = writer ?? new StringWriter();
			engine = engine ?? new AspViewEngine();
			cookies = cookies ?? new Dictionary<string, HttpCookie>();
			request = request ?? new MockRequest(cookies);
			response = response ?? new MockResponse(cookies);
			url = url ?? new UrlInfo("", "Stub", "Stub");
			trace = trace ?? new MockTrace();
			propertyBag = propertyBag ?? new Hashtable();
			monoRailServices = monoRailServices ?? new MockServices();
			context = context ?? new MockEngineContext(request, response, monoRailServices, url);
			flash = flash ?? context.Flash;
			controller = controller ?? new ControllerStub();
			controllerContext = controllerContext ?? new ControllerContextStub();
			controllerContext.PropertyBag = propertyBag;
			context.Flash = flash;
		}

		/// <summary>
		/// Creating default stub and mocks
		/// </summary>
		protected virtual void Clear()
		{
			expected = null;
			writer = null;
			engine = null;
			cookies = null;
			request = null;
			response = null;
			url = null;
			trace = null;
			propertyBag = null;
			flash = null;
			controller = null;
			context = null;
		}

		protected void InitializeView(Type viewType)
		{
			view = (IViewBaseInternal)Activator.CreateInstance(viewType);
			InitializeView();
		}

		protected void InitializeView(IViewBaseInternal viewInstance)
		{
			viewInstance.Initialize(engine, writer, context, controller, controllerContext);
		}
		
		protected void InitializeView()
		{
			InitializeView(view);
		}

		protected void SetLayout(Type layoutType)
		{
			IViewBaseInternal layout = (IViewBaseInternal)Activator.CreateInstance(layoutType);
			InitializeView(layout);
			layout.ContentView = view;
			view = layout;
		}

		protected void AssertViewOutputEqualsToExpected()
		{
			Assert.Equal(expected, ViewOutput, "View output differ. Output was:\r\n" + ViewOutput);
		}

		protected virtual string ViewOutput
		{
			get { return writer.GetStringBuilder().ToString(); }
		}

	}
}
