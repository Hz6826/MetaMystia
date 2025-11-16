using System;
using System.Runtime.InteropServices;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000AE RID: 174
	public static class GuestGuardMappingHelper : Object
	{
		// Token: 0x060012C0 RID: 4800 RVA: 0x000DD7B8 File Offset: 0x000DB9B8
		// Note: this type is marked as 'beforefieldinit'.
		static GuestGuardMappingHelper()
		{
			Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "GuestGuardMappingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr);
			GuestGuardMappingHelper.NativeFieldInfoPtr_PASSIVE_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "PASSIVE_LINE");
			GuestGuardMappingHelper.NativeFieldInfoPtr_YOUSEI_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "YOUSEI_LINE");
			GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL1_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "LEVEL1_LINE");
			GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL2_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "LEVEL2_LINE");
			GuestGuardMappingHelper.NativeFieldInfoPtr_ULTIMATE_SKILL_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "ULTIMATE_SKILL_LINE");
			GuestGuardMappingHelper.NativeMethodInfoPtr_ModifyCharacterElement_Public_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, 100666541);
			GuestGuardMappingHelper.NativeMethodInfoPtr_GetCharacterName_Public_Static_String_GuestGuardMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, 100666542);
			GuestGuardMappingHelper.NativeMethodInfoPtr_FormatString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, 100666543);
			GuestGuardMappingHelper.NativeMethodInfoPtr_GetLang_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, 100666544);
			GuestGuardMappingHelper.NativeMethodInfoPtr_GetText_Public_Static_String_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, 100666545);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000DD8B0 File Offset: 0x000DBAB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 52075, RefRangeEnd = 52082, XrefRangeStart = 52015, XrefRangeEnd = 52075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ModifyCharacterElement(UIElementCluster uiElement, [In] ref GuestGuardMapping guard, bool modifyName = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(guard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.NativeMethodInfoPtr_ModifyCharacterElement_Public_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000DD908 File Offset: 0x000DBB08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52092, RefRangeEnd = 52095, XrefRangeStart = 52082, XrefRangeEnd = 52092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCharacterName(GuestGuardMapping guard, bool useBrief = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useBrief;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.NativeMethodInfoPtr_GetCharacterName_Public_Static_String_GuestGuardMapping_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000DD958 File Offset: 0x000DBB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52100, RefRangeEnd = 52101, XrefRangeStart = 52095, XrefRangeEnd = 52100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatString(string data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.NativeMethodInfoPtr_FormatString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000DD994 File Offset: 0x000DBB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52101, XrefRangeEnd = 52102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLang(string titleLang)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(titleLang);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.NativeMethodInfoPtr_GetLang_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000DD9D0 File Offset: 0x000DBBD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52154, RefRangeEnd = 52157, XrefRangeStart = 52102, XrefRangeEnd = 52154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetText(GuestGuardMapping guard)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.NativeMethodInfoPtr_GetText_Public_Static_String_GuestGuardMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0000BF02 File Offset: 0x0000A102
		public GuestGuardMappingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000DDA14 File Offset: 0x000DBC14
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000BF0B File Offset: 0x0000A10B
		public unsafe static int PASSIVE_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestGuardMappingHelper.NativeFieldInfoPtr_PASSIVE_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestGuardMappingHelper.NativeFieldInfoPtr_PASSIVE_LINE, (void*)(&value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000DDA30 File Offset: 0x000DBC30
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000BF19 File Offset: 0x0000A119
		public unsafe static int YOUSEI_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestGuardMappingHelper.NativeFieldInfoPtr_YOUSEI_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestGuardMappingHelper.NativeFieldInfoPtr_YOUSEI_LINE, (void*)(&value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000DDA4C File Offset: 0x000DBC4C
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0000BF27 File Offset: 0x0000A127
		public unsafe static int LEVEL1_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL1_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL1_LINE, (void*)(&value));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000DDA68 File Offset: 0x000DBC68
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0000BF35 File Offset: 0x0000A135
		public unsafe static int LEVEL2_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL2_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestGuardMappingHelper.NativeFieldInfoPtr_LEVEL2_LINE, (void*)(&value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000DDA84 File Offset: 0x000DBC84
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0000BF43 File Offset: 0x0000A143
		public unsafe static int ULTIMATE_SKILL_LINE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestGuardMappingHelper.NativeFieldInfoPtr_ULTIMATE_SKILL_LINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestGuardMappingHelper.NativeFieldInfoPtr_ULTIMATE_SKILL_LINE, (void*)(&value));
			}
		}

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_PASSIVE_LINE;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_YOUSEI_LINE;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL1_LINE;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL2_LINE;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_ULTIMATE_SKILL_LINE;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_ModifyCharacterElement_Public_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterName_Public_Static_String_GuestGuardMapping_Boolean_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_FormatString_Private_Static_String_String_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_GetLang_Public_Static_String_String_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_GuestGuardMapping_0;

		// Token: 0x020005BF RID: 1471
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.GuestGuardMappingHelper+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06008CB3 RID: 36019 RVA: 0x0026A31C File Offset: 0x0026851C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr);
				GuestGuardMappingHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr, "characterVisual");
				GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr, 100666546);
				GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ModifyCharacterElement_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr, 100666547);
				GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ModifyCharacterElement_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr, 100666548);
			}

			// Token: 0x06008CB4 RID: 36020 RVA: 0x0026A398 File Offset: 0x00268598
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CB5 RID: 36021 RVA: 0x0026A3D4 File Offset: 0x002685D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ModifyCharacterElement_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ModifyCharacterElement_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CB6 RID: 36022 RVA: 0x0026A418 File Offset: 0x00268618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ModifyCharacterElement_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ModifyCharacterElement_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CB7 RID: 36023 RVA: 0x0004BAB2 File Offset: 0x00049CB2
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F15 RID: 12053
			// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x0026A45C File Offset: 0x0026865C
			// (set) Token: 0x06008CB9 RID: 36025 RVA: 0x0004BABB File Offset: 0x00049CBB
			public unsafe CharacterSpriteSetCompact characterVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMappingHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_characterVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMappingHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C05 RID: 23557
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

			// Token: 0x04005C06 RID: 23558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C07 RID: 23559
			private static readonly IntPtr NativeMethodInfoPtr__ModifyCharacterElement_b__0_Internal_Void_Image_0;

			// Token: 0x04005C08 RID: 23560
			private static readonly IntPtr NativeMethodInfoPtr__ModifyCharacterElement_b__1_Internal_Void_Image_0;
		}

		// Token: 0x020005C0 RID: 1472
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.GuestGuardMappingHelper+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Object
		{
			// Token: 0x06008CBA RID: 36026 RVA: 0x0026A48C File Offset: 0x0026868C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestGuardMappingHelper>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr);
				GuestGuardMappingHelper.__c__DisplayClass5_1.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr, "characterVisual");
				GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr, 100666549);
				GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ModifyCharacterElement_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr, 100666550);
				GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ModifyCharacterElement_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr, 100666551);
			}

			// Token: 0x06008CBB RID: 36027 RVA: 0x0026A508 File Offset: 0x00268708
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestGuardMappingHelper.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CBC RID: 36028 RVA: 0x0026A544 File Offset: 0x00268744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ModifyCharacterElement_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ModifyCharacterElement_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CBD RID: 36029 RVA: 0x0026A588 File Offset: 0x00268788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ModifyCharacterElement_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMappingHelper.__c__DisplayClass5_1.NativeMethodInfoPtr__ModifyCharacterElement_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CBE RID: 36030 RVA: 0x0004BADA File Offset: 0x00049CDA
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F16 RID: 12054
			// (get) Token: 0x06008CBF RID: 36031 RVA: 0x0026A5CC File Offset: 0x002687CC
			// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x0004BAE3 File Offset: 0x00049CE3
			public unsafe CharacterSpriteSetCompact characterVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMappingHelper.__c__DisplayClass5_1.NativeFieldInfoPtr_characterVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMappingHelper.__c__DisplayClass5_1.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C09 RID: 23561
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

			// Token: 0x04005C0A RID: 23562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C0B RID: 23563
			private static readonly IntPtr NativeMethodInfoPtr__ModifyCharacterElement_b__2_Internal_Void_Image_0;

			// Token: 0x04005C0C RID: 23564
			private static readonly IntPtr NativeMethodInfoPtr__ModifyCharacterElement_b__3_Internal_Void_Image_0;
		}
	}
}
