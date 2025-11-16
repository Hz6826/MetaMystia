using System;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000356 RID: 854
	public class Tips : MonoBehaviour
	{
		// Token: 0x060064A0 RID: 25760 RVA: 0x001EE6BC File Offset: 0x001EC8BC
		// Note: this type is marked as 'beforefieldinit'.
		static Tips()
		{
			Il2CppClassPointerStore<Tips>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "Tips");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tips>.NativeClassPtr);
			Tips.NativeFieldInfoPtr_storeLockdownTips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips>.NativeClassPtr, "storeLockdownTips");
			Tips.NativeFieldInfoPtr_importantMissionTips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips>.NativeClassPtr, "importantMissionTips");
			Tips.NativeFieldInfoPtr_shopUpgrateMissionTips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips>.NativeClassPtr, "shopUpgrateMissionTips");
			Tips.NativeFieldInfoPtr_hasInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips>.NativeClassPtr, "hasInitialized");
			Tips.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684386);
			Tips.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684387);
			Tips.NativeMethodInfoPtr_TryRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684388);
			Tips.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684389);
			Tips.NativeMethodInfoPtr_PerformRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684390);
			Tips.NativeMethodInfoPtr_StoreLockdownTipsRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684391);
			Tips.NativeMethodInfoPtr_ImportantMissionTipsRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684392);
			Tips.NativeMethodInfoPtr_ChenShopUpgradeEventTipsRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684393);
			Tips.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684394);
			Tips.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips>.NativeClassPtr, 100684395);
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x001EE804 File Offset: 0x001ECA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258829, XrefRangeEnd = 258846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x001EE838 File Offset: 0x001ECA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258846, XrefRangeEnd = 258860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x001EE86C File Offset: 0x001ECA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258861, RefRangeEnd = 258862, XrefRangeStart = 258860, XrefRangeEnd = 258861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_TryRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x001EE8A0 File Offset: 0x001ECAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258862, XrefRangeEnd = 258876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x001EE8D4 File Offset: 0x001ECAD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258910, RefRangeEnd = 258912, XrefRangeStart = 258876, XrefRangeEnd = 258910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_PerformRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x001EE908 File Offset: 0x001ECB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258912, XrefRangeEnd = 258926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreLockdownTipsRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_StoreLockdownTipsRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x001EE93C File Offset: 0x001ECB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258926, XrefRangeEnd = 258938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportantMissionTipsRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_ImportantMissionTipsRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x001EE970 File Offset: 0x001ECB70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258965, RefRangeEnd = 258966, XrefRangeStart = 258938, XrefRangeEnd = 258965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChenShopUpgradeEventTipsRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr_ChenShopUpgradeEventTipsRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x001EE9A4 File Offset: 0x001ECBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tips.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x001EE9E0 File Offset: 0x001ECBE0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tips() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tips>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x000366FE File Offset: 0x000348FE
		public Tips(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		// (set) Token: 0x060064AD RID: 25773 RVA: 0x00036707 File Offset: 0x00034907
		public unsafe TextMeshProUGUI storeLockdownTips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_storeLockdownTips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_storeLockdownTips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x060064AE RID: 25774 RVA: 0x001EEA4C File Offset: 0x001ECC4C
		// (set) Token: 0x060064AF RID: 25775 RVA: 0x00036726 File Offset: 0x00034926
		public unsafe TextMeshProUGUI importantMissionTips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_importantMissionTips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_importantMissionTips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x060064B0 RID: 25776 RVA: 0x001EEA7C File Offset: 0x001ECC7C
		// (set) Token: 0x060064B1 RID: 25777 RVA: 0x00036745 File Offset: 0x00034945
		public unsafe TextMeshProUGUI shopUpgrateMissionTips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_shopUpgrateMissionTips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_shopUpgrateMissionTips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x060064B2 RID: 25778 RVA: 0x001EEAAC File Offset: 0x001ECCAC
		// (set) Token: 0x060064B3 RID: 25779 RVA: 0x00036764 File Offset: 0x00034964
		public unsafe bool hasInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_hasInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tips.NativeFieldInfoPtr_hasInitialized)) = value;
			}
		}

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeFieldInfoPtr_storeLockdownTips;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeFieldInfoPtr_importantMissionTips;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeFieldInfoPtr_shopUpgrateMissionTips;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeFieldInfoPtr_hasInitialized;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeMethodInfoPtr_TryRefresh_Public_Void_0;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeMethodInfoPtr_PerformRefresh_Private_Void_0;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeMethodInfoPtr_StoreLockdownTipsRefresh_Private_Void_0;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeMethodInfoPtr_ImportantMissionTipsRefresh_Private_Void_0;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeMethodInfoPtr_ChenShopUpgradeEventTipsRefresh_Private_Void_0;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E0C RID: 3596
		[ObfuscatedName("Common.UI.Tips+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601030C RID: 66316 RVA: 0x003C61BC File Offset: 0x003C43BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Tips.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tips>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr);
				Tips.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr, "<>9");
				Tips.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr, "<>9__11_0");
				Tips.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr, 100684397);
				Tips.__c.NativeMethodInfoPtr__ChenShopUpgradeEventTipsRefresh_b__11_0_Internal_Boolean_EventNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr, 100684398);
			}

			// Token: 0x0601030D RID: 66317 RVA: 0x003C6238 File Offset: 0x003C4438
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tips.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601030E RID: 66318 RVA: 0x003C6274 File Offset: 0x003C4474
			[CallerCount(0)]
			public unsafe bool _ChenShopUpgradeEventTipsRefresh_b__11_0(EventNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tips.__c.NativeMethodInfoPtr__ChenShopUpgradeEventTipsRefresh_b__11_0_Internal_Boolean_EventNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601030F RID: 66319 RVA: 0x0008CE51 File Offset: 0x0008B051
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054A7 RID: 21671
			// (get) Token: 0x06010310 RID: 66320 RVA: 0x003C62C4 File Offset: 0x003C44C4
			// (set) Token: 0x06010311 RID: 66321 RVA: 0x0008CE5A File Offset: 0x0008B05A
			public unsafe static Tips.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Tips.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tips.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Tips.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054A8 RID: 21672
			// (get) Token: 0x06010312 RID: 66322 RVA: 0x003C62EC File Offset: 0x003C44EC
			// (set) Token: 0x06010313 RID: 66323 RVA: 0x0008CE6C File Offset: 0x0008B06C
			public unsafe static Func<EventNode, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Tips.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EventNode, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Tips.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A44C RID: 42060
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A44D RID: 42061
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400A44E RID: 42062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A44F RID: 42063
			private static readonly IntPtr NativeMethodInfoPtr__ChenShopUpgradeEventTipsRefresh_b__11_0_Internal_Boolean_EventNode_0;
		}
	}
}
