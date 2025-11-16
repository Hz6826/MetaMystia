using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200013E RID: 318
	public class DS_MWorkSessionStart_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002621 RID: 9761 RVA: 0x0011E67C File Offset: 0x0011C87C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MWorkSessionStart_Behaviour()
		{
			Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MWorkSessionStart_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr);
			DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_cookerConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, "cookerConfigurations");
			DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, "dailyBeverages");
			DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, "dailyRecipes");
			DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_izakayaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, "izakayaIndex");
			DS_MWorkSessionStart_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, 100670166);
			DS_MWorkSessionStart_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr, 100670167);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0011E724 File Offset: 0x0011C924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90145, XrefRangeEnd = 90155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MWorkSessionStart_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0011E760 File Offset: 0x0011C960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90155, XrefRangeEnd = 90156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MWorkSessionStart_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MWorkSessionStart_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MWorkSessionStart_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000167FA File Offset: 0x000149FA
		public DS_MWorkSessionStart_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x0011E79C File Offset: 0x0011C99C
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x00016803 File Offset: 0x00014A03
		public unsafe Il2CppStructArray<DaySceneDirector.IndexCookerPair> cookerConfigurations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_cookerConfigurations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DaySceneDirector.IndexCookerPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_cookerConfigurations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x0011E7CC File Offset: 0x0011C9CC
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x00016822 File Offset: 0x00014A22
		public unsafe Il2CppStructArray<int> dailyBeverages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyBeverages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x0011E7FC File Offset: 0x0011C9FC
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x00016841 File Offset: 0x00014A41
		public unsafe Il2CppStructArray<int> dailyRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_dailyRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x0011E82C File Offset: 0x0011CA2C
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x00016860 File Offset: 0x00014A60
		public unsafe int izakayaIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_izakayaIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart_Behaviour.NativeFieldInfoPtr_izakayaIndex)) = value;
			}
		}

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeFieldInfoPtr_cookerConfigurations;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr_dailyBeverages;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr_dailyRecipes;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr_izakayaIndex;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
