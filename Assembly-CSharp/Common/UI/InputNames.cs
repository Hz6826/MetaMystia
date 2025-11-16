using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Common.UI
{
	// Token: 0x02000350 RID: 848
	public static class InputNames : Object
	{
		// Token: 0x0600645E RID: 25694 RVA: 0x00036518 File Offset: 0x00034718
		// Note: this type is marked as 'beforefieldinit'.
		static InputNames()
		{
			Il2CppClassPointerStore<InputNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "InputNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames>.NativeClassPtr);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0003653D File Offset: 0x0003473D
		public InputNames(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x02000E06 RID: 3590
		public static class Map : Object
		{
			// Token: 0x060102F1 RID: 66289 RVA: 0x003C5D24 File Offset: 0x003C3F24
			// Note: this type is marked as 'beforefieldinit'.
			static Map()
			{
				Il2CppClassPointerStore<InputNames.Map>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames>.NativeClassPtr, "Map");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Map>.NativeClassPtr);
				InputNames.Map.NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputNames.Map>.NativeClassPtr, "UI");
				InputNames.Map.NativeFieldInfoPtr_NightScene_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputNames.Map>.NativeClassPtr, "NightScene_Player");
				InputNames.Map.NativeFieldInfoPtr_DayScene_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputNames.Map>.NativeClassPtr, "DayScene_Player");
			}

			// Token: 0x060102F2 RID: 66290 RVA: 0x0008CD87 File Offset: 0x0008AF87
			public Map(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700549F RID: 21663
			// (get) Token: 0x060102F3 RID: 66291 RVA: 0x003C5D8C File Offset: 0x003C3F8C
			// (set) Token: 0x060102F4 RID: 66292 RVA: 0x0008CD90 File Offset: 0x0008AF90
			public unsafe static string UI
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputNames.Map.NativeFieldInfoPtr_UI, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputNames.Map.NativeFieldInfoPtr_UI, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170054A0 RID: 21664
			// (get) Token: 0x060102F5 RID: 66293 RVA: 0x003C5DAC File Offset: 0x003C3FAC
			// (set) Token: 0x060102F6 RID: 66294 RVA: 0x0008CDA2 File Offset: 0x0008AFA2
			public unsafe static string NightScene_Player
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputNames.Map.NativeFieldInfoPtr_NightScene_Player, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputNames.Map.NativeFieldInfoPtr_NightScene_Player, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170054A1 RID: 21665
			// (get) Token: 0x060102F7 RID: 66295 RVA: 0x003C5DCC File Offset: 0x003C3FCC
			// (set) Token: 0x060102F8 RID: 66296 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
			public unsafe static string DayScene_Player
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputNames.Map.NativeFieldInfoPtr_DayScene_Player, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputNames.Map.NativeFieldInfoPtr_DayScene_Player, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A43D RID: 42045
			private static readonly IntPtr NativeFieldInfoPtr_UI;

			// Token: 0x0400A43E RID: 42046
			private static readonly IntPtr NativeFieldInfoPtr_NightScene_Player;

			// Token: 0x0400A43F RID: 42047
			private static readonly IntPtr NativeFieldInfoPtr_DayScene_Player;
		}

		// Token: 0x02000E07 RID: 3591
		public static class Action : Object
		{
			// Token: 0x060102F9 RID: 66297 RVA: 0x0008CDC6 File Offset: 0x0008AFC6
			// Note: this type is marked as 'beforefieldinit'.
			static Action()
			{
				Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames>.NativeClassPtr, "Action");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr);
			}

			// Token: 0x060102FA RID: 66298 RVA: 0x0008CDE6 File Offset: 0x0008AFE6
			public Action(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x020010AA RID: 4266
			public static class UI : Object
			{
				// Token: 0x06012262 RID: 74338 RVA: 0x00423C98 File Offset: 0x00421E98
				// Note: this type is marked as 'beforefieldinit'.
				static UI()
				{
					Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr, "UI");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684301);
					InputNames.Action.UI.NativeMethodInfoPtr_get_FreeMove_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684302);
					InputNames.Action.UI.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684303);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684304);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684305);
					InputNames.Action.UI.NativeMethodInfoPtr_get_RightClick_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684306);
					InputNames.Action.UI.NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684307);
					InputNames.Action.UI.NativeMethodInfoPtr_get_PrimerySwitch_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684308);
					InputNames.Action.UI.NativeMethodInfoPtr_get_SecondarySwitch_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684309);
					InputNames.Action.UI.NativeMethodInfoPtr_get_TertiarySwitch_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684310);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Submit_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684311);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Cancel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684312);
					InputNames.Action.UI.NativeMethodInfoPtr_get_DayScene_SelectAll_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684313);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Scroll_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684314);
					InputNames.Action.UI.NativeMethodInfoPtr_get_NightScene_Daily_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684315);
					InputNames.Action.UI.NativeMethodInfoPtr_get_NightScene_SwitchBuff_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684316);
					InputNames.Action.UI.NativeMethodInfoPtr_get_DayScene_GuideMap_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684317);
					InputNames.Action.UI.NativeMethodInfoPtr_get_PrepNightScene_OpenSubMenu_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684318);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684319);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_2_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684320);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_2_GamePad_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684321);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684322);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_2_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684323);
					InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_2_GamePad_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684324);
					InputNames.Action.UI.NativeMethodInfoPtr_get_Copy_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.UI>.NativeClassPtr, 100684325);
				}

				// Token: 0x17005ECA RID: 24266
				// (get) Token: 0x06012263 RID: 74339 RVA: 0x00423EB8 File Offset: 0x004220B8
				public unsafe static string Move
				{
					[CallerCount(8)]
					[CachedScanResults(RefRangeStart = 258165, RefRangeEnd = 258173, XrefRangeStart = 258163, XrefRangeEnd = 258165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ECB RID: 24267
				// (get) Token: 0x06012264 RID: 74340 RVA: 0x00423EE4 File Offset: 0x004220E4
				public unsafe static string FreeMove
				{
					[CallerCount(4)]
					[CachedScanResults(RefRangeStart = 258175, RefRangeEnd = 258179, XrefRangeStart = 258173, XrefRangeEnd = 258175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_FreeMove_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ECC RID: 24268
				// (get) Token: 0x06012265 RID: 74341 RVA: 0x00423F10 File Offset: 0x00422110
				public unsafe static string NoteBook
				{
					[CallerCount(5)]
					[CachedScanResults(RefRangeStart = 258181, RefRangeEnd = 258186, XrefRangeStart = 258179, XrefRangeEnd = 258181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ECD RID: 24269
				// (get) Token: 0x06012266 RID: 74342 RVA: 0x00423F3C File Offset: 0x0042213C
				public unsafe static string Storage
				{
					[CallerCount(3)]
					[CachedScanResults(RefRangeStart = 258188, RefRangeEnd = 258191, XrefRangeStart = 258186, XrefRangeEnd = 258188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ECE RID: 24270
				// (get) Token: 0x06012267 RID: 74343 RVA: 0x00423F68 File Offset: 0x00422168
				public unsafe static string Menu
				{
					[CallerCount(9)]
					[CachedScanResults(RefRangeStart = 258193, RefRangeEnd = 258202, XrefRangeStart = 258191, XrefRangeEnd = 258193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ECF RID: 24271
				// (get) Token: 0x06012268 RID: 74344 RVA: 0x00423F94 File Offset: 0x00422194
				public unsafe static string RightClick
				{
					[CallerCount(6)]
					[CachedScanResults(RefRangeStart = 258204, RefRangeEnd = 258210, XrefRangeStart = 258202, XrefRangeEnd = 258204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_RightClick_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED0 RID: 24272
				// (get) Token: 0x06012269 RID: 74345 RVA: 0x00423FC0 File Offset: 0x004221C0
				public unsafe static string LeftClick
				{
					[CallerCount(6)]
					[CachedScanResults(RefRangeStart = 258212, RefRangeEnd = 258218, XrefRangeStart = 258210, XrefRangeEnd = 258212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED1 RID: 24273
				// (get) Token: 0x0601226A RID: 74346 RVA: 0x00423FEC File Offset: 0x004221EC
				public unsafe static string PrimerySwitch
				{
					[CallerCount(18)]
					[CachedScanResults(RefRangeStart = 258220, RefRangeEnd = 258238, XrefRangeStart = 258218, XrefRangeEnd = 258220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_PrimerySwitch_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED2 RID: 24274
				// (get) Token: 0x0601226B RID: 74347 RVA: 0x00424018 File Offset: 0x00422218
				public unsafe static string SecondarySwitch
				{
					[CallerCount(29)]
					[CachedScanResults(RefRangeStart = 258240, RefRangeEnd = 258269, XrefRangeStart = 258238, XrefRangeEnd = 258240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_SecondarySwitch_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED3 RID: 24275
				// (get) Token: 0x0601226C RID: 74348 RVA: 0x00424044 File Offset: 0x00422244
				public unsafe static string TertiarySwitch
				{
					[CallerCount(27)]
					[CachedScanResults(RefRangeStart = 258271, RefRangeEnd = 258298, XrefRangeStart = 258269, XrefRangeEnd = 258271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_TertiarySwitch_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED4 RID: 24276
				// (get) Token: 0x0601226D RID: 74349 RVA: 0x00424070 File Offset: 0x00422270
				public unsafe static string Submit
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 258300, RefRangeEnd = 258307, XrefRangeStart = 258298, XrefRangeEnd = 258300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Submit_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED5 RID: 24277
				// (get) Token: 0x0601226E RID: 74350 RVA: 0x0042409C File Offset: 0x0042229C
				public unsafe static string Cancel
				{
					[CallerCount(6)]
					[CachedScanResults(RefRangeStart = 258309, RefRangeEnd = 258315, XrefRangeStart = 258307, XrefRangeEnd = 258309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Cancel_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED6 RID: 24278
				// (get) Token: 0x0601226F RID: 74351 RVA: 0x004240C8 File Offset: 0x004222C8
				public unsafe static string DayScene_SelectAll
				{
					[CallerCount(9)]
					[CachedScanResults(RefRangeStart = 258317, RefRangeEnd = 258326, XrefRangeStart = 258315, XrefRangeEnd = 258317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_DayScene_SelectAll_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED7 RID: 24279
				// (get) Token: 0x06012270 RID: 74352 RVA: 0x004240F4 File Offset: 0x004222F4
				public unsafe static string Scroll
				{
					[CallerCount(8)]
					[CachedScanResults(RefRangeStart = 258328, RefRangeEnd = 258336, XrefRangeStart = 258326, XrefRangeEnd = 258328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Scroll_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED8 RID: 24280
				// (get) Token: 0x06012271 RID: 74353 RVA: 0x00424120 File Offset: 0x00422320
				public unsafe static string NightScene_Daily
				{
					[CallerCount(12)]
					[CachedScanResults(RefRangeStart = 258338, RefRangeEnd = 258350, XrefRangeStart = 258336, XrefRangeEnd = 258338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_NightScene_Daily_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005ED9 RID: 24281
				// (get) Token: 0x06012272 RID: 74354 RVA: 0x0042414C File Offset: 0x0042234C
				public unsafe static string NightScene_SwitchBuff
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258352, RefRangeEnd = 258354, XrefRangeStart = 258350, XrefRangeEnd = 258352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_NightScene_SwitchBuff_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDA RID: 24282
				// (get) Token: 0x06012273 RID: 74355 RVA: 0x00424178 File Offset: 0x00422378
				public unsafe static string DayScene_GuideMap
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258356, RefRangeEnd = 258357, XrefRangeStart = 258354, XrefRangeEnd = 258356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_DayScene_GuideMap_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDB RID: 24283
				// (get) Token: 0x06012274 RID: 74356 RVA: 0x004241A4 File Offset: 0x004223A4
				public unsafe static string PrepNightScene_OpenSubMenu
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258359, RefRangeEnd = 258360, XrefRangeStart = 258357, XrefRangeEnd = 258359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_PrepNightScene_OpenSubMenu_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDC RID: 24284
				// (get) Token: 0x06012275 RID: 74357 RVA: 0x004241D0 File Offset: 0x004223D0
				public unsafe static string QTEPlayLeft
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258362, RefRangeEnd = 258364, XrefRangeStart = 258360, XrefRangeEnd = 258362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDD RID: 24285
				// (get) Token: 0x06012276 RID: 74358 RVA: 0x004241FC File Offset: 0x004223FC
				public unsafe static string QTEPlayLeft_2
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258366, RefRangeEnd = 258368, XrefRangeStart = 258364, XrefRangeEnd = 258366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_2_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDE RID: 24286
				// (get) Token: 0x06012277 RID: 74359 RVA: 0x00424228 File Offset: 0x00422428
				public unsafe static string QTEPlayLeft_2_GamePad
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258370, RefRangeEnd = 258372, XrefRangeStart = 258368, XrefRangeEnd = 258370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayLeft_2_GamePad_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EDF RID: 24287
				// (get) Token: 0x06012278 RID: 74360 RVA: 0x00424254 File Offset: 0x00422454
				public unsafe static string QTEPlayRight
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258374, RefRangeEnd = 258376, XrefRangeStart = 258372, XrefRangeEnd = 258374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE0 RID: 24288
				// (get) Token: 0x06012279 RID: 74361 RVA: 0x00424280 File Offset: 0x00422480
				public unsafe static string QTEPlayRight_2
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258378, RefRangeEnd = 258380, XrefRangeStart = 258376, XrefRangeEnd = 258378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_2_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE1 RID: 24289
				// (get) Token: 0x0601227A RID: 74362 RVA: 0x004242AC File Offset: 0x004224AC
				public unsafe static string QTEPlayRight_2_GamePad
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258382, RefRangeEnd = 258384, XrefRangeStart = 258380, XrefRangeEnd = 258382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_QTEPlayRight_2_GamePad_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE2 RID: 24290
				// (get) Token: 0x0601227B RID: 74363 RVA: 0x004242D8 File Offset: 0x004224D8
				public unsafe static string Copy
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258386, RefRangeEnd = 258387, XrefRangeStart = 258384, XrefRangeEnd = 258386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.UI.NativeMethodInfoPtr_get_Copy_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0601227C RID: 74364 RVA: 0x0009DAB6 File Offset: 0x0009BCB6
				public UI(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B7EF RID: 47087
				private static readonly IntPtr NativeMethodInfoPtr_get_Move_Public_Static_get_String_0;

				// Token: 0x0400B7F0 RID: 47088
				private static readonly IntPtr NativeMethodInfoPtr_get_FreeMove_Public_Static_get_String_0;

				// Token: 0x0400B7F1 RID: 47089
				private static readonly IntPtr NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0;

				// Token: 0x0400B7F2 RID: 47090
				private static readonly IntPtr NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0;

				// Token: 0x0400B7F3 RID: 47091
				private static readonly IntPtr NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0;

				// Token: 0x0400B7F4 RID: 47092
				private static readonly IntPtr NativeMethodInfoPtr_get_RightClick_Public_Static_get_String_0;

				// Token: 0x0400B7F5 RID: 47093
				private static readonly IntPtr NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0;

				// Token: 0x0400B7F6 RID: 47094
				private static readonly IntPtr NativeMethodInfoPtr_get_PrimerySwitch_Public_Static_get_String_0;

				// Token: 0x0400B7F7 RID: 47095
				private static readonly IntPtr NativeMethodInfoPtr_get_SecondarySwitch_Public_Static_get_String_0;

				// Token: 0x0400B7F8 RID: 47096
				private static readonly IntPtr NativeMethodInfoPtr_get_TertiarySwitch_Public_Static_get_String_0;

				// Token: 0x0400B7F9 RID: 47097
				private static readonly IntPtr NativeMethodInfoPtr_get_Submit_Public_Static_get_String_0;

				// Token: 0x0400B7FA RID: 47098
				private static readonly IntPtr NativeMethodInfoPtr_get_Cancel_Public_Static_get_String_0;

				// Token: 0x0400B7FB RID: 47099
				private static readonly IntPtr NativeMethodInfoPtr_get_DayScene_SelectAll_Public_Static_get_String_0;

				// Token: 0x0400B7FC RID: 47100
				private static readonly IntPtr NativeMethodInfoPtr_get_Scroll_Public_Static_get_String_0;

				// Token: 0x0400B7FD RID: 47101
				private static readonly IntPtr NativeMethodInfoPtr_get_NightScene_Daily_Public_Static_get_String_0;

				// Token: 0x0400B7FE RID: 47102
				private static readonly IntPtr NativeMethodInfoPtr_get_NightScene_SwitchBuff_Public_Static_get_String_0;

				// Token: 0x0400B7FF RID: 47103
				private static readonly IntPtr NativeMethodInfoPtr_get_DayScene_GuideMap_Public_Static_get_String_0;

				// Token: 0x0400B800 RID: 47104
				private static readonly IntPtr NativeMethodInfoPtr_get_PrepNightScene_OpenSubMenu_Public_Static_get_String_0;

				// Token: 0x0400B801 RID: 47105
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayLeft_Public_Static_get_String_0;

				// Token: 0x0400B802 RID: 47106
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayLeft_2_Public_Static_get_String_0;

				// Token: 0x0400B803 RID: 47107
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayLeft_2_GamePad_Public_Static_get_String_0;

				// Token: 0x0400B804 RID: 47108
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayRight_Public_Static_get_String_0;

				// Token: 0x0400B805 RID: 47109
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayRight_2_Public_Static_get_String_0;

				// Token: 0x0400B806 RID: 47110
				private static readonly IntPtr NativeMethodInfoPtr_get_QTEPlayRight_2_GamePad_Public_Static_get_String_0;

				// Token: 0x0400B807 RID: 47111
				private static readonly IntPtr NativeMethodInfoPtr_get_Copy_Public_Static_get_String_0;
			}

			// Token: 0x020010AB RID: 4267
			public static class NightScene_Player : Object
			{
				// Token: 0x0601227D RID: 74365 RVA: 0x00424304 File Offset: 0x00422504
				// Note: this type is marked as 'beforefieldinit'.
				static NightScene_Player()
				{
					Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr, "NightScene_Player");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684326);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684327);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_ThrowDeliver_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684328);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_MouseThrowDeliver_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684329);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Daily_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684330);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_SwitchOrder_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684331);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_SwitchBuff_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684332);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Kick_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684333);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684334);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684335);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684336);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684337);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684338);
					InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Extra_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.NightScene_Player>.NativeClassPtr, 100684339);
				}

				// Token: 0x17005EE3 RID: 24291
				// (get) Token: 0x0601227E RID: 74366 RVA: 0x00424448 File Offset: 0x00422648
				public unsafe static string Interact
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258389, RefRangeEnd = 258391, XrefRangeStart = 258387, XrefRangeEnd = 258389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE4 RID: 24292
				// (get) Token: 0x0601227F RID: 74367 RVA: 0x00424474 File Offset: 0x00422674
				public unsafe static string MouseInteract
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258393, RefRangeEnd = 258394, XrefRangeStart = 258391, XrefRangeEnd = 258393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE5 RID: 24293
				// (get) Token: 0x06012280 RID: 74368 RVA: 0x004244A0 File Offset: 0x004226A0
				public unsafe static string ThrowDeliver
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258396, RefRangeEnd = 258398, XrefRangeStart = 258394, XrefRangeEnd = 258396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_ThrowDeliver_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE6 RID: 24294
				// (get) Token: 0x06012281 RID: 74369 RVA: 0x004244CC File Offset: 0x004226CC
				public unsafe static string MouseThrowDeliver
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258400, RefRangeEnd = 258401, XrefRangeStart = 258398, XrefRangeEnd = 258400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_MouseThrowDeliver_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE7 RID: 24295
				// (get) Token: 0x06012282 RID: 74370 RVA: 0x004244F8 File Offset: 0x004226F8
				public unsafe static string Daily
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258403, RefRangeEnd = 258404, XrefRangeStart = 258401, XrefRangeEnd = 258403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Daily_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE8 RID: 24296
				// (get) Token: 0x06012283 RID: 74371 RVA: 0x00424524 File Offset: 0x00422724
				public unsafe static string SwitchOrder
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258406, RefRangeEnd = 258408, XrefRangeStart = 258404, XrefRangeEnd = 258406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_SwitchOrder_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EE9 RID: 24297
				// (get) Token: 0x06012284 RID: 74372 RVA: 0x00424550 File Offset: 0x00422750
				public unsafe static string SwitchBuff
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258410, RefRangeEnd = 258412, XrefRangeStart = 258408, XrefRangeEnd = 258410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_SwitchBuff_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EEA RID: 24298
				// (get) Token: 0x06012285 RID: 74373 RVA: 0x0042457C File Offset: 0x0042277C
				public unsafe static string Kick
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258414, RefRangeEnd = 258416, XrefRangeStart = 258412, XrefRangeEnd = 258414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Kick_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EEB RID: 24299
				// (get) Token: 0x06012286 RID: 74374 RVA: 0x004245A8 File Offset: 0x004227A8
				public unsafe static string FastForward
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258418, RefRangeEnd = 258419, XrefRangeStart = 258416, XrefRangeEnd = 258418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EEC RID: 24300
				// (get) Token: 0x06012287 RID: 74375 RVA: 0x004245D4 File Offset: 0x004227D4
				public unsafe static string Move
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258421, RefRangeEnd = 258423, XrefRangeStart = 258419, XrefRangeEnd = 258421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EED RID: 24301
				// (get) Token: 0x06012288 RID: 74376 RVA: 0x00424600 File Offset: 0x00422800
				public unsafe static string NoteBook
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258425, RefRangeEnd = 258426, XrefRangeStart = 258423, XrefRangeEnd = 258425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EEE RID: 24302
				// (get) Token: 0x06012289 RID: 74377 RVA: 0x0042462C File Offset: 0x0042282C
				public unsafe static string Storage
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258428, RefRangeEnd = 258429, XrefRangeStart = 258426, XrefRangeEnd = 258428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EEF RID: 24303
				// (get) Token: 0x0601228A RID: 74378 RVA: 0x00424658 File Offset: 0x00422858
				public unsafe static string Menu
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258431, RefRangeEnd = 258432, XrefRangeStart = 258429, XrefRangeEnd = 258431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF0 RID: 24304
				// (get) Token: 0x0601228B RID: 74379 RVA: 0x00424684 File Offset: 0x00422884
				public unsafe static string Extra
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258434, RefRangeEnd = 258435, XrefRangeStart = 258432, XrefRangeEnd = 258434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.NightScene_Player.NativeMethodInfoPtr_get_Extra_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0601228C RID: 74380 RVA: 0x0009DABF File Offset: 0x0009BCBF
				public NightScene_Player(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B808 RID: 47112
				private static readonly IntPtr NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0;

				// Token: 0x0400B809 RID: 47113
				private static readonly IntPtr NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0;

				// Token: 0x0400B80A RID: 47114
				private static readonly IntPtr NativeMethodInfoPtr_get_ThrowDeliver_Public_Static_get_String_0;

				// Token: 0x0400B80B RID: 47115
				private static readonly IntPtr NativeMethodInfoPtr_get_MouseThrowDeliver_Public_Static_get_String_0;

				// Token: 0x0400B80C RID: 47116
				private static readonly IntPtr NativeMethodInfoPtr_get_Daily_Public_Static_get_String_0;

				// Token: 0x0400B80D RID: 47117
				private static readonly IntPtr NativeMethodInfoPtr_get_SwitchOrder_Public_Static_get_String_0;

				// Token: 0x0400B80E RID: 47118
				private static readonly IntPtr NativeMethodInfoPtr_get_SwitchBuff_Public_Static_get_String_0;

				// Token: 0x0400B80F RID: 47119
				private static readonly IntPtr NativeMethodInfoPtr_get_Kick_Public_Static_get_String_0;

				// Token: 0x0400B810 RID: 47120
				private static readonly IntPtr NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0;

				// Token: 0x0400B811 RID: 47121
				private static readonly IntPtr NativeMethodInfoPtr_get_Move_Public_Static_get_String_0;

				// Token: 0x0400B812 RID: 47122
				private static readonly IntPtr NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0;

				// Token: 0x0400B813 RID: 47123
				private static readonly IntPtr NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0;

				// Token: 0x0400B814 RID: 47124
				private static readonly IntPtr NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0;

				// Token: 0x0400B815 RID: 47125
				private static readonly IntPtr NativeMethodInfoPtr_get_Extra_Public_Static_get_String_0;
			}

			// Token: 0x020010AC RID: 4268
			public static class DayScene_Player : Object
			{
				// Token: 0x0601228D RID: 74381 RVA: 0x004246B0 File Offset: 0x004228B0
				// Note: this type is marked as 'beforefieldinit'.
				static DayScene_Player()
				{
					Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr, "DayScene_Player");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Sprint_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684340);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_MouseSprint_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684341);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684342);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684343);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684344);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684345);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684346);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684347);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684348);
					InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_GuideMap_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.DayScene_Player>.NativeClassPtr, 100684349);
				}

				// Token: 0x17005EF1 RID: 24305
				// (get) Token: 0x0601228E RID: 74382 RVA: 0x004247A4 File Offset: 0x004229A4
				public unsafe static string Sprint
				{
					[CallerCount(4)]
					[CachedScanResults(RefRangeStart = 258437, RefRangeEnd = 258441, XrefRangeStart = 258435, XrefRangeEnd = 258437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Sprint_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF2 RID: 24306
				// (get) Token: 0x0601228F RID: 74383 RVA: 0x004247D0 File Offset: 0x004229D0
				public unsafe static string MouseSprint
				{
					[CallerCount(3)]
					[CachedScanResults(RefRangeStart = 258443, RefRangeEnd = 258446, XrefRangeStart = 258441, XrefRangeEnd = 258443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_MouseSprint_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF3 RID: 24307
				// (get) Token: 0x06012290 RID: 74384 RVA: 0x004247FC File Offset: 0x004229FC
				public unsafe static string NoteBook
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258448, RefRangeEnd = 258449, XrefRangeStart = 258446, XrefRangeEnd = 258448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF4 RID: 24308
				// (get) Token: 0x06012291 RID: 74385 RVA: 0x00424828 File Offset: 0x00422A28
				public unsafe static string Storage
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258451, RefRangeEnd = 258452, XrefRangeStart = 258449, XrefRangeEnd = 258451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF5 RID: 24309
				// (get) Token: 0x06012292 RID: 74386 RVA: 0x00424854 File Offset: 0x00422A54
				public unsafe static string Menu
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258454, RefRangeEnd = 258455, XrefRangeStart = 258452, XrefRangeEnd = 258454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF6 RID: 24310
				// (get) Token: 0x06012293 RID: 74387 RVA: 0x00424880 File Offset: 0x00422A80
				public unsafe static string Move
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 258457, RefRangeEnd = 258459, XrefRangeStart = 258455, XrefRangeEnd = 258457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Move_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF7 RID: 24311
				// (get) Token: 0x06012294 RID: 74388 RVA: 0x004248AC File Offset: 0x00422AAC
				public unsafe static string MouseInteract
				{
					[CallerCount(4)]
					[CachedScanResults(RefRangeStart = 258461, RefRangeEnd = 258465, XrefRangeStart = 258459, XrefRangeEnd = 258461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF8 RID: 24312
				// (get) Token: 0x06012295 RID: 74389 RVA: 0x004248D8 File Offset: 0x00422AD8
				public unsafe static string Interact
				{
					[CallerCount(5)]
					[CachedScanResults(RefRangeStart = 258467, RefRangeEnd = 258472, XrefRangeStart = 258465, XrefRangeEnd = 258467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EF9 RID: 24313
				// (get) Token: 0x06012296 RID: 74390 RVA: 0x00424904 File Offset: 0x00422B04
				public unsafe static string FastForward
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258474, RefRangeEnd = 258475, XrefRangeStart = 258472, XrefRangeEnd = 258474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EFA RID: 24314
				// (get) Token: 0x06012297 RID: 74391 RVA: 0x00424930 File Offset: 0x00422B30
				public unsafe static string GuideMap
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258477, RefRangeEnd = 258478, XrefRangeStart = 258475, XrefRangeEnd = 258477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.DayScene_Player.NativeMethodInfoPtr_get_GuideMap_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06012298 RID: 74392 RVA: 0x0009DAC8 File Offset: 0x0009BCC8
				public DayScene_Player(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B816 RID: 47126
				private static readonly IntPtr NativeMethodInfoPtr_get_Sprint_Public_Static_get_String_0;

				// Token: 0x0400B817 RID: 47127
				private static readonly IntPtr NativeMethodInfoPtr_get_MouseSprint_Public_Static_get_String_0;

				// Token: 0x0400B818 RID: 47128
				private static readonly IntPtr NativeMethodInfoPtr_get_NoteBook_Public_Static_get_String_0;

				// Token: 0x0400B819 RID: 47129
				private static readonly IntPtr NativeMethodInfoPtr_get_Storage_Public_Static_get_String_0;

				// Token: 0x0400B81A RID: 47130
				private static readonly IntPtr NativeMethodInfoPtr_get_Menu_Public_Static_get_String_0;

				// Token: 0x0400B81B RID: 47131
				private static readonly IntPtr NativeMethodInfoPtr_get_Move_Public_Static_get_String_0;

				// Token: 0x0400B81C RID: 47132
				private static readonly IntPtr NativeMethodInfoPtr_get_MouseInteract_Public_Static_get_String_0;

				// Token: 0x0400B81D RID: 47133
				private static readonly IntPtr NativeMethodInfoPtr_get_Interact_Public_Static_get_String_0;

				// Token: 0x0400B81E RID: 47134
				private static readonly IntPtr NativeMethodInfoPtr_get_FastForward_Public_Static_get_String_0;

				// Token: 0x0400B81F RID: 47135
				private static readonly IntPtr NativeMethodInfoPtr_get_GuideMap_Public_Static_get_String_0;
			}

			// Token: 0x020010AD RID: 4269
			public static class Shared : Object
			{
				// Token: 0x06012299 RID: 74393 RVA: 0x0042495C File Offset: 0x00422B5C
				// Note: this type is marked as 'beforefieldinit'.
				static Shared()
				{
					Il2CppClassPointerStore<InputNames.Action.Shared>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputNames.Action>.NativeClassPtr, "Shared");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputNames.Action.Shared>.NativeClassPtr);
					InputNames.Action.Shared.NativeMethodInfoPtr_get_Point_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.Shared>.NativeClassPtr, 100684350);
					InputNames.Action.Shared.NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputNames.Action.Shared>.NativeClassPtr, 100684351);
				}

				// Token: 0x17005EFB RID: 24315
				// (get) Token: 0x0601229A RID: 74394 RVA: 0x004249B0 File Offset: 0x00422BB0
				public unsafe static string Point
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 258480, RefRangeEnd = 258481, XrefRangeStart = 258478, XrefRangeEnd = 258480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.Shared.NativeMethodInfoPtr_get_Point_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005EFC RID: 24316
				// (get) Token: 0x0601229B RID: 74395 RVA: 0x004249DC File Offset: 0x00422BDC
				public unsafe static string LeftClick
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258481, XrefRangeEnd = 258483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputNames.Action.Shared.NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x0601229C RID: 74396 RVA: 0x0009DAD1 File Offset: 0x0009BCD1
				public Shared(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B820 RID: 47136
				private static readonly IntPtr NativeMethodInfoPtr_get_Point_Public_Static_get_String_0;

				// Token: 0x0400B821 RID: 47137
				private static readonly IntPtr NativeMethodInfoPtr_get_LeftClick_Public_Static_get_String_0;
			}
		}
	}
}
