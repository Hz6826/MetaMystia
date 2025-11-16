using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	public class KyoukoTutorialData_Memory : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x06005604 RID: 22020 RVA: 0x001C07C4 File Offset: 0x001BE9C4
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_Memory()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_Memory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr);
			KyoukoTutorialData_Memory.NativeFieldInfoPtr_FreshManTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, "FreshManTip");
			KyoukoTutorialData_Memory.NativeFieldInfoPtr_HowToSatisfySpecialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, "HowToSatisfySpecialGuest");
			KyoukoTutorialData_Memory.NativeFieldInfoPtr_WhatIsQTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, "WhatIsQTE");
			KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, "AboutFly");
			KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutToutetsu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, "AboutToutetsu");
			KyoukoTutorialData_Memory.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, 100680825);
			KyoukoTutorialData_Memory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr, 100680826);
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06005605 RID: 22021 RVA: 0x001C0880 File Offset: 0x001BEA80
		public unsafe override Il2CppReferenceArray<KyoukoTutorialData> ChildKyoukoTutorialData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214002, XrefRangeEnd = 214015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_Memory.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KyoukoTutorialData>>(intPtr3) : null;
			}
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x001C08CC File Offset: 0x001BEACC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_Memory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_Memory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_Memory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
		public KyoukoTutorialData_Memory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x001C0908 File Offset: 0x001BEB08
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x0002E4D9 File Offset: 0x0002C6D9
		public unsafe KyoukoTutorialData_FreshManTip FreshManTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_FreshManTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_FreshManTip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_FreshManTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x001C0938 File Offset: 0x001BEB38
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x0002E4F8 File Offset: 0x0002C6F8
		public unsafe KyoukoTutorialData_HowToSatisfySpecialGuest HowToSatisfySpecialGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_HowToSatisfySpecialGuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_HowToSatisfySpecialGuest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_HowToSatisfySpecialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x001C0968 File Offset: 0x001BEB68
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x0002E517 File Offset: 0x0002C717
		public unsafe KyoukoTutorialData_WhatIsQTE WhatIsQTE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_WhatIsQTE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_WhatIsQTE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_WhatIsQTE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x001C0998 File Offset: 0x001BEB98
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x0002E536 File Offset: 0x0002C736
		public unsafe KyoukoTutorialData AboutFly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutFly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutFly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x001C09C8 File Offset: 0x001BEBC8
		// (set) Token: 0x06005611 RID: 22033 RVA: 0x0002E555 File Offset: 0x0002C755
		public unsafe KyoukoTutorialData_AboutToutetsu AboutToutetsu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutToutetsu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_AboutToutetsu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Memory.NativeFieldInfoPtr_AboutToutetsu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeFieldInfoPtr_FreshManTip;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeFieldInfoPtr_HowToSatisfySpecialGuest;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeFieldInfoPtr_WhatIsQTE;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeFieldInfoPtr_AboutFly;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeFieldInfoPtr_AboutToutetsu;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
