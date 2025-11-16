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
	// Token: 0x020003FC RID: 1020
	public class COM_Items_Out : PlayableAsset
	{
		// Token: 0x06007714 RID: 30484 RVA: 0x0022AE34 File Offset: 0x00229034
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Items_Out()
		{
			Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Items_Out");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr);
			COM_Items_Out.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr, "items");
			COM_Items_Out.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr, 100687547);
			COM_Items_Out.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr, 100687548);
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x0022AEA0 File Offset: 0x002290A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293028, XrefRangeEnd = 293041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Items_Out.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x0022AF08 File Offset: 0x00229108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Items_Out() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Items_Out>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Items_Out.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x000406B9 File Offset: 0x0003E8B9
		public COM_Items_Out(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x0022AF44 File Offset: 0x00229144
		// (set) Token: 0x06007719 RID: 30489 RVA: 0x000406C2 File Offset: 0x0003E8C2
		public unsafe Il2CppReferenceArray<Product> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_Out.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_Out.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EB9 RID: 20153
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04004EBA RID: 20154
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EBB RID: 20155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
