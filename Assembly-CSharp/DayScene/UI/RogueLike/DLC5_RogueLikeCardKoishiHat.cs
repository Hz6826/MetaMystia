using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E5 RID: 229
	public class DLC5_RogueLikeCardKoishiHat : RogueLikeCard
	{
		// Token: 0x06001ABD RID: 6845 RVA: 0x000F7928 File Offset: 0x000F5B28
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardKoishiHat()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardKoishiHat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr);
			DLC5_RogueLikeCardKoishiHat.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, "multiplier");
			DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, 100668098);
			DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, 100668099);
			DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, 100668100);
			DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, 100668101);
			DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, 100668102);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000F79D0 File Offset: 0x000F5BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70987, XrefRangeEnd = 70994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000F7A50 File Offset: 0x000F5C50
		[CallerCount(0)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000F7AC8 File Offset: 0x000F5CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70994, XrefRangeEnd = 70999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000F7B2C File Offset: 0x000F5D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardKoishiHat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000F7B68 File Offset: 0x000F5D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000107F6 File Offset: 0x0000E9F6
		public DLC5_RogueLikeCardKoishiHat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x000F7BE0 File Offset: 0x000F5DE0
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x000107FF File Offset: 0x0000E9FF
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x020006A7 RID: 1703
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardKoishiHat+<UseCard>d__1")]
		public sealed class _UseCard_d__1 : Object
		{
			// Token: 0x0600980F RID: 38927 RVA: 0x0028ABB4 File Offset: 0x00288DB4
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat>.NativeClassPtr, "<UseCard>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668103);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668104);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668105);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668106);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668107);
				DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr, 100668108);
			}

			// Token: 0x06009810 RID: 38928 RVA: 0x0028ACD0 File Offset: 0x00288ED0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardKoishiHat._UseCard_d__1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009811 RID: 38929 RVA: 0x0028AD18 File Offset: 0x00288F18
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009812 RID: 38930 RVA: 0x0028AD4C File Offset: 0x00288F4C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700328C RID: 12940
			// (get) Token: 0x06009813 RID: 38931 RVA: 0x0028AD88 File Offset: 0x00288F88
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009814 RID: 38932 RVA: 0x0028ADC8 File Offset: 0x00288FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70981, XrefRangeEnd = 70987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700328D RID: 12941
			// (get) Token: 0x06009815 RID: 38933 RVA: 0x0028ADFC File Offset: 0x00288FFC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009816 RID: 38934 RVA: 0x00052467 File Offset: 0x00050667
			public _UseCard_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003286 RID: 12934
			// (get) Token: 0x06009817 RID: 38935 RVA: 0x0028AE3C File Offset: 0x0028903C
			// (set) Token: 0x06009818 RID: 38936 RVA: 0x00052470 File Offset: 0x00050670
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003287 RID: 12935
			// (get) Token: 0x06009819 RID: 38937 RVA: 0x0028AE64 File Offset: 0x00289064
			// (set) Token: 0x0600981A RID: 38938 RVA: 0x0005248B File Offset: 0x0005068B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003288 RID: 12936
			// (get) Token: 0x0600981B RID: 38939 RVA: 0x0028AE94 File Offset: 0x00289094
			// (set) Token: 0x0600981C RID: 38940 RVA: 0x000524AA File Offset: 0x000506AA
			public unsafe DLC5_RogueLikeCardKoishiHat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardKoishiHat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003289 RID: 12937
			// (get) Token: 0x0600981D RID: 38941 RVA: 0x0028AEC4 File Offset: 0x002890C4
			// (set) Token: 0x0600981E RID: 38942 RVA: 0x000524C9 File Offset: 0x000506C9
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700328A RID: 12938
			// (get) Token: 0x0600981F RID: 38943 RVA: 0x0028AEF4 File Offset: 0x002890F4
			// (set) Token: 0x06009820 RID: 38944 RVA: 0x000524F7 File Offset: 0x000506F7
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700328B RID: 12939
			// (get) Token: 0x06009821 RID: 38945 RVA: 0x0028AF1C File Offset: 0x0028911C
			// (set) Token: 0x06009822 RID: 38946 RVA: 0x00052512 File Offset: 0x00050712
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardKoishiHat._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400628A RID: 25226
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400628B RID: 25227
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400628C RID: 25228
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400628D RID: 25229
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x0400628E RID: 25230
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x0400628F RID: 25231
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04006290 RID: 25232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006291 RID: 25233
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006292 RID: 25234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006293 RID: 25235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006294 RID: 25236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006295 RID: 25237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
