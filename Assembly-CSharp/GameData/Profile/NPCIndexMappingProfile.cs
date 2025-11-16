using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E4 RID: 740
	public class NPCIndexMappingProfile : ScriptableObject
	{
		// Token: 0x060059EB RID: 23019 RVA: 0x001CBF58 File Offset: 0x001CA158
		// Note: this type is marked as 'beforefieldinit'.
		static NPCIndexMappingProfile()
		{
			Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NPCIndexMappingProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr);
			NPCIndexMappingProfile.NativeFieldInfoPtr_NPCIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr, "NPCIndex");
			NPCIndexMappingProfile.NativeMethodInfoPtr_GetDictionary_Public_Dictionary_2_String_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr, 100681384);
			NPCIndexMappingProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr, 100681385);
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x001CBFC4 File Offset: 0x001CA1C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219644, RefRangeEnd = 219646, XrefRangeStart = 219611, XrefRangeEnd = 219644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, SchedulerNode.Character> GetDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.NativeMethodInfoPtr_GetDictionary_Public_Dictionary_2_String_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode.Character>>(intPtr3) : null;
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x001CC004 File Offset: 0x001CA204
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCIndexMappingProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x00030925 File Offset: 0x0002EB25
		public NPCIndexMappingProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x001CC040 File Offset: 0x001CA240
		// (set) Token: 0x060059F0 RID: 23024 RVA: 0x0003092E File Offset: 0x0002EB2E
		public unsafe Il2CppReferenceArray<NPCIndexMappingProfile.StringIdentityPair> NPCIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.NativeFieldInfoPtr_NPCIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPCIndexMappingProfile.StringIdentityPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.NativeFieldInfoPtr_NPCIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeFieldInfoPtr_NPCIndex;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionary_Public_Dictionary_2_String_Character_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CAE RID: 3246
		[Serializable]
		public sealed class StringIdentityPair : ValueType
		{
			// Token: 0x0600E8AF RID: 59567 RVA: 0x0037AEF0 File Offset: 0x003790F0
			// Note: this type is marked as 'beforefieldinit'.
			static StringIdentityPair()
			{
				Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr, "StringIdentityPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr);
				NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_StringName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr, "StringName");
				NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_Identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr, "Identity");
				NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr__ctor_Public_Void_String_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr, 100681386);
				NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr_get_StringNameData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr, 100681387);
				NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr_get_IdentityData_Public_get_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr, 100681388);
			}

			// Token: 0x0600E8B0 RID: 59568 RVA: 0x0037AF80 File Offset: 0x00379180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219610, XrefRangeEnd = 219611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringIdentityPair(string stringName, SchedulerNode.Character identity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringName);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref identity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr__ctor_Public_Void_String_Character_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BA5 RID: 19365
			// (get) Token: 0x0600E8B1 RID: 59569 RVA: 0x0037AFE0 File Offset: 0x003791E0
			public unsafe string StringNameData
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr_get_StringNameData_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004BA6 RID: 19366
			// (get) Token: 0x0600E8B2 RID: 59570 RVA: 0x0037B01C File Offset: 0x0037921C
			public unsafe SchedulerNode.Character IdentityData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.StringIdentityPair.NativeMethodInfoPtr_get_IdentityData_Public_get_Character_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E8B3 RID: 59571 RVA: 0x0007C683 File Offset: 0x0007A883
			public StringIdentityPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E8B4 RID: 59572 RVA: 0x0007C68C File Offset: 0x0007A88C
			public StringIdentityPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCIndexMappingProfile.StringIdentityPair>.NativeClassPtr))
			{
			}

			// Token: 0x17004BA3 RID: 19363
			// (get) Token: 0x0600E8B5 RID: 59573 RVA: 0x0037B060 File Offset: 0x00379260
			// (set) Token: 0x0600E8B6 RID: 59574 RVA: 0x0007C69E File Offset: 0x0007A89E
			public unsafe string StringName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_StringName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_StringName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BA4 RID: 19364
			// (get) Token: 0x0600E8B7 RID: 59575 RVA: 0x0037B088 File Offset: 0x00379288
			// (set) Token: 0x0600E8B8 RID: 59576 RVA: 0x0007C6BD File Offset: 0x0007A8BD
			public unsafe SchedulerNode.Character Identity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_Identity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCIndexMappingProfile.StringIdentityPair.NativeFieldInfoPtr_Identity)) = value;
				}
			}

			// Token: 0x04009469 RID: 37993
			private static readonly IntPtr NativeFieldInfoPtr_StringName;

			// Token: 0x0400946A RID: 37994
			private static readonly IntPtr NativeFieldInfoPtr_Identity;

			// Token: 0x0400946B RID: 37995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Character_0;

			// Token: 0x0400946C RID: 37996
			private static readonly IntPtr NativeMethodInfoPtr_get_StringNameData_Public_get_String_0;

			// Token: 0x0400946D RID: 37997
			private static readonly IntPtr NativeMethodInfoPtr_get_IdentityData_Public_get_Character_0;
		}

		// Token: 0x02000CAF RID: 3247
		[ObfuscatedName("GameData.Profile.NPCIndexMappingProfile+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E8B9 RID: 59577 RVA: 0x0037B0B0 File Offset: 0x003792B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCIndexMappingProfile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr);
				NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, "<>9");
				NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, "<>9__1_0");
				NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, "<>9__1_1");
				NPCIndexMappingProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, 100681390);
				NPCIndexMappingProfile.__c.NativeMethodInfoPtr__GetDictionary_b__1_0_Internal_String_StringIdentityPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, 100681391);
				NPCIndexMappingProfile.__c.NativeMethodInfoPtr__GetDictionary_b__1_1_Internal_Character_StringIdentityPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr, 100681392);
			}

			// Token: 0x0600E8BA RID: 59578 RVA: 0x0037B154 File Offset: 0x00379354
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCIndexMappingProfile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8BB RID: 59579 RVA: 0x0037B190 File Offset: 0x00379390
			[CallerCount(0)]
			public unsafe string _GetDictionary_b__1_0(NPCIndexMappingProfile.StringIdentityPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.__c.NativeMethodInfoPtr__GetDictionary_b__1_0_Internal_String_StringIdentityPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E8BC RID: 59580 RVA: 0x0037B1E0 File Offset: 0x003793E0
			[CallerCount(0)]
			public unsafe SchedulerNode.Character _GetDictionary_b__1_1(NPCIndexMappingProfile.StringIdentityPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCIndexMappingProfile.__c.NativeMethodInfoPtr__GetDictionary_b__1_1_Internal_Character_StringIdentityPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8BD RID: 59581 RVA: 0x0007C6D8 File Offset: 0x0007A8D8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BA7 RID: 19367
			// (get) Token: 0x0600E8BE RID: 59582 RVA: 0x0037B234 File Offset: 0x00379434
			// (set) Token: 0x0600E8BF RID: 59583 RVA: 0x0007C6E1 File Offset: 0x0007A8E1
			public unsafe static NPCIndexMappingProfile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCIndexMappingProfile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BA8 RID: 19368
			// (get) Token: 0x0600E8C0 RID: 59584 RVA: 0x0037B25C File Offset: 0x0037945C
			// (set) Token: 0x0600E8C1 RID: 59585 RVA: 0x0007C6F3 File Offset: 0x0007A8F3
			public unsafe static Func<NPCIndexMappingProfile.StringIdentityPair, string> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCIndexMappingProfile.StringIdentityPair, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BA9 RID: 19369
			// (get) Token: 0x0600E8C2 RID: 59586 RVA: 0x0037B284 File Offset: 0x00379484
			// (set) Token: 0x0600E8C3 RID: 59587 RVA: 0x0007C705 File Offset: 0x0007A905
			public unsafe static Func<NPCIndexMappingProfile.StringIdentityPair, SchedulerNode.Character> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCIndexMappingProfile.StringIdentityPair, SchedulerNode.Character>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCIndexMappingProfile.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400946E RID: 37998
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400946F RID: 37999
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04009470 RID: 38000
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04009471 RID: 38001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009472 RID: 38002
			private static readonly IntPtr NativeMethodInfoPtr__GetDictionary_b__1_0_Internal_String_StringIdentityPair_0;

			// Token: 0x04009473 RID: 38003
			private static readonly IntPtr NativeMethodInfoPtr__GetDictionary_b__1_1_Internal_Character_StringIdentityPair_0;
		}
	}
}
