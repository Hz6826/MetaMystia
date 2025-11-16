using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000EC RID: 236
	public class DLC5_RogueLikeCardPhoto : RogueLikeCard
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x000F8514 File Offset: 0x000F6714
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPhoto()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPhoto");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr);
			DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_mappingDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "mappingDatas");
			DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_PHOTOGENIC_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "PHOTOGENIC_ID");
			DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_GINKGO_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "GINKGO_ID");
			DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, 100668142);
			DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, 100668143);
			DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, 100668144);
			DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, 100668145);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x000F85E4 File Offset: 0x000F67E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71180, XrefRangeEnd = 71186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x000F8664 File Offset: 0x000F6864
		[CallerCount(0)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000F86DC File Offset: 0x000F68DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71186, XrefRangeEnd = 71198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000F8740 File Offset: 0x000F6940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPhoto() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000108A9 File Offset: 0x0000EAA9
		public DLC5_RogueLikeCardPhoto(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x000F877C File Offset: 0x000F697C
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x000108B2 File Offset: 0x0000EAB2
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000F87AC File Offset: 0x000F69AC
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x000108D1 File Offset: 0x0000EAD1
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeCardPhoto.IngredientMapping> mappingDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_mappingDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeCardPhoto.IngredientMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_mappingDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000F87DC File Offset: 0x000F69DC
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x000108F0 File Offset: 0x0000EAF0
		public unsafe static int PHOTOGENIC_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_PHOTOGENIC_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_PHOTOGENIC_ID, (void*)(&value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x000F87F8 File Offset: 0x000F69F8
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x000108FE File Offset: 0x0000EAFE
		public unsafe static int GINKGO_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_GINKGO_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPhoto.NativeFieldInfoPtr_GINKGO_ID, (void*)(&value));
			}
		}

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_mappingDatas;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_PHOTOGENIC_ID;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_GINKGO_ID;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006AC RID: 1708
		[Serializable]
		public sealed class IngredientMapping : ValueType
		{
			// Token: 0x06009855 RID: 38997 RVA: 0x0028B82C File Offset: 0x00289A2C
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientMapping()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto.IngredientMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "IngredientMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto.IngredientMapping>.NativeClassPtr);
				DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto.IngredientMapping>.NativeClassPtr, "map");
				DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto.IngredientMapping>.NativeClassPtr, "id");
			}

			// Token: 0x06009856 RID: 38998 RVA: 0x000526FB File Offset: 0x000508FB
			public IngredientMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009857 RID: 38999 RVA: 0x00052704 File Offset: 0x00050904
			public IngredientMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto.IngredientMapping>.NativeClassPtr))
			{
			}

			// Token: 0x1700329E RID: 12958
			// (get) Token: 0x06009858 RID: 39000 RVA: 0x0028B880 File Offset: 0x00289A80
			// (set) Token: 0x06009859 RID: 39001 RVA: 0x00052716 File Offset: 0x00050916
			public unsafe Il2CppStringArray map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_map);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700329F RID: 12959
			// (get) Token: 0x0600985A RID: 39002 RVA: 0x0028B8B0 File Offset: 0x00289AB0
			// (set) Token: 0x0600985B RID: 39003 RVA: 0x00052735 File Offset: 0x00050935
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto.IngredientMapping.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x040062B2 RID: 25266
			private static readonly IntPtr NativeFieldInfoPtr_map;

			// Token: 0x040062B3 RID: 25267
			private static readonly IntPtr NativeFieldInfoPtr_id;
		}

		// Token: 0x020006AD RID: 1709
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPhoto+<UseCard>d__5")]
		public sealed class _UseCard_d__5 : Object
		{
			// Token: 0x0600985C RID: 39004 RVA: 0x0028B8D8 File Offset: 0x00289AD8
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__5()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto>.NativeClassPtr, "<UseCard>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668146);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668147);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668148);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668149);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668150);
				DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr, 100668151);
			}

			// Token: 0x0600985D RID: 39005 RVA: 0x0028B9E0 File Offset: 0x00289BE0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPhoto._UseCard_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600985E RID: 39006 RVA: 0x0028BA28 File Offset: 0x00289C28
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600985F RID: 39007 RVA: 0x0028BA5C File Offset: 0x00289C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71152, XrefRangeEnd = 71174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170032A5 RID: 12965
			// (get) Token: 0x06009860 RID: 39008 RVA: 0x0028BA98 File Offset: 0x00289C98
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009861 RID: 39009 RVA: 0x0028BAD8 File Offset: 0x00289CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71174, XrefRangeEnd = 71180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170032A6 RID: 12966
			// (get) Token: 0x06009862 RID: 39010 RVA: 0x0028BB0C File Offset: 0x00289D0C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009863 RID: 39011 RVA: 0x00052750 File Offset: 0x00050950
			public _UseCard_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032A0 RID: 12960
			// (get) Token: 0x06009864 RID: 39012 RVA: 0x0028BB4C File Offset: 0x00289D4C
			// (set) Token: 0x06009865 RID: 39013 RVA: 0x00052759 File Offset: 0x00050959
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170032A1 RID: 12961
			// (get) Token: 0x06009866 RID: 39014 RVA: 0x0028BB74 File Offset: 0x00289D74
			// (set) Token: 0x06009867 RID: 39015 RVA: 0x00052774 File Offset: 0x00050974
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A2 RID: 12962
			// (get) Token: 0x06009868 RID: 39016 RVA: 0x0028BBA4 File Offset: 0x00289DA4
			// (set) Token: 0x06009869 RID: 39017 RVA: 0x00052793 File Offset: 0x00050993
			public unsafe DLC5_RogueLikeCardPhoto __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPhoto>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A3 RID: 12963
			// (get) Token: 0x0600986A RID: 39018 RVA: 0x0028BBD4 File Offset: 0x00289DD4
			// (set) Token: 0x0600986B RID: 39019 RVA: 0x000527B2 File Offset: 0x000509B2
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032A4 RID: 12964
			// (get) Token: 0x0600986C RID: 39020 RVA: 0x0028BC04 File Offset: 0x00289E04
			// (set) Token: 0x0600986D RID: 39021 RVA: 0x000527D1 File Offset: 0x000509D1
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPhoto._UseCard_d__5.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x040062B4 RID: 25268
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040062B5 RID: 25269
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040062B6 RID: 25270
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062B7 RID: 25271
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062B8 RID: 25272
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040062B9 RID: 25273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040062BA RID: 25274
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062BB RID: 25275
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040062BC RID: 25276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040062BD RID: 25277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062BE RID: 25278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
