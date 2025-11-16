using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003FB RID: 1019
	public class COM_Items_In : PlayableAsset
	{
		// Token: 0x0600770C RID: 30476 RVA: 0x0022ACB8 File Offset: 0x00228EB8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Items_In()
		{
			Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Items_In");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr);
			COM_Items_In.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr, "items");
			COM_Items_In.NativeFieldInfoPtr_suppressCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr, "suppressCallbacks");
			COM_Items_In.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr, 100687545);
			COM_Items_In.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr, 100687546);
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x0022AD38 File Offset: 0x00228F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293013, XrefRangeEnd = 293028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Items_In.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x0022ADA0 File Offset: 0x00228FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Items_In() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Items_In>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Items_In.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00040676 File Offset: 0x0003E876
		public COM_Items_In(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x06007710 RID: 30480 RVA: 0x0022ADDC File Offset: 0x00228FDC
		// (set) Token: 0x06007711 RID: 30481 RVA: 0x0004067F File Offset: 0x0003E87F
		public unsafe Il2CppReferenceArray<Product> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x06007712 RID: 30482 RVA: 0x0022AE0C File Offset: 0x0022900C
		// (set) Token: 0x06007713 RID: 30483 RVA: 0x0004069E File Offset: 0x0003E89E
		public unsafe bool suppressCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In.NativeFieldInfoPtr_suppressCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In.NativeFieldInfoPtr_suppressCallbacks)) = value;
			}
		}

		// Token: 0x04004EB5 RID: 20149
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04004EB6 RID: 20150
		private static readonly IntPtr NativeFieldInfoPtr_suppressCallbacks;

		// Token: 0x04004EB7 RID: 20151
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EB8 RID: 20152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
