using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x020001AF RID: 431
	public class InteractableTile : Tile
	{
		// Token: 0x0600341C RID: 13340 RVA: 0x00151904 File Offset: 0x0014FB04
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableTile()
		{
			Il2CppClassPointerStore<InteractableTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.Tiles", "InteractableTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableTile>.NativeClassPtr);
			InteractableTile.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableTile>.NativeClassPtr, "type");
			InteractableTile.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableTile>.NativeClassPtr, "index");
			InteractableTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableTile>.NativeClassPtr, 100673281);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00151970 File Offset: 0x0014FB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123979, XrefRangeEnd = 123980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0001CF9A File Offset: 0x0001B19A
		public InteractableTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x001519AC File Offset: 0x0014FBAC
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x0001CFA3 File Offset: 0x0001B1A3
		public unsafe InteractableTile.TileType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableTile.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableTile.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x001519D4 File Offset: 0x0014FBD4
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x0001CFBE File Offset: 0x0001B1BE
		public unsafe byte index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableTile.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableTile.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008FB RID: 2299
		public enum TileType
		{
			// Token: 0x04007604 RID: 30212
			CookDesk,
			// Token: 0x04007605 RID: 30213
			FoodStorage,
			// Token: 0x04007606 RID: 30214
			BeverageStorage,
			// Token: 0x04007607 RID: 30215
			Trash,
			// Token: 0x04007608 RID: 30216
			GuestTable,
			// Token: 0x04007609 RID: 30217
			GuestSeat,
			// Token: 0x0400760A RID: 30218
			LEGACY_HeadOfLine,
			// Token: 0x0400760B RID: 30219
			LEGACY_TailOfLine,
			// Token: 0x0400760C RID: 30220
			GuestSpawnA,
			// Token: 0x0400760D RID: 30221
			GuestSpawnB,
			// Token: 0x0400760E RID: 30222
			PlayerSpawn,
			// Token: 0x0400760F RID: 30223
			PlayerBorder,
			// Token: 0x04007610 RID: 30224
			WaitSeat,
			// Token: 0x04007611 RID: 30225
			InDoor,
			// Token: 0x04007612 RID: 30226
			OutDoor,
			// Token: 0x04007613 RID: 30227
			AreaA,
			// Token: 0x04007614 RID: 30228
			AreaB,
			// Token: 0x04007615 RID: 30229
			DoorA,
			// Token: 0x04007616 RID: 30230
			DoorB,
			// Token: 0x04007617 RID: 30231
			Line,
			// Token: 0x04007618 RID: 30232
			PasserBorder,
			// Token: 0x04007619 RID: 30233
			AIdle,
			// Token: 0x0400761A RID: 30234
			RabbitIdle,
			// Token: 0x0400761B RID: 30235
			FoodStorage_BOSS,
			// Token: 0x0400761C RID: 30236
			BeverageStorage_BOSS,
			// Token: 0x0400761D RID: 30237
			Trash_BOSS,
			// Token: 0x0400761E RID: 30238
			FurnitureArea_Ground,
			// Token: 0x0400761F RID: 30239
			FurnitureArea_Wall,
			// Token: 0x04007620 RID: 30240
			FurnitureArea_Carpet,
			// Token: 0x04007621 RID: 30241
			Null
		}
	}
}
