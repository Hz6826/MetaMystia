using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000155 RID: 341
	public class DS_NPC_Chat : PlayableAsset
	{
		// Token: 0x0600272B RID: 10027 RVA: 0x001212AC File Offset: 0x0011F4AC
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Chat()
		{
			Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Chat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr);
			DS_NPC_Chat.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr, "characterLabel");
			DS_NPC_Chat.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr, 100670246);
			DS_NPC_Chat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr, 100670247);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00121318 File Offset: 0x0011F518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90804, XrefRangeEnd = 90817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Chat.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00121380 File Offset: 0x0011F580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Chat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Chat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Chat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00017184 File Offset: 0x00015384
		public DS_NPC_Chat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x001213BC File Offset: 0x0011F5BC
		// (set) Token: 0x06002730 RID: 10032 RVA: 0x0001718D File Offset: 0x0001538D
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Chat.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Chat.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
